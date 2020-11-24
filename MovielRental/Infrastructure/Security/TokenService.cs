using Microsoft.IdentityModel.Tokens;
using MovieDAL.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MovielRental.Infrastructure.Security
{
    public class TokenService : ITokenService
    {
        private const string Passphrase = "C62A_3egAY*s!M#YDd-67n?ESQ&kTJD7@j_^rJe_k?S!q&sKU$-J3D*FG@87#G^56ZZSpc*b3u!Pq=4UP6ETm+VxzqKr!ahULG8Pm2p6=vBnQUDk52xsE4q2P^BM=spp";

        private const string Prefixe = "Bearer ";

        private JwtSecurityTokenHandler _handler;
        private JwtHeader _header;

        private JwtSecurityTokenHandler Handler
        {
            get
            {
                return _handler ??= new JwtSecurityTokenHandler();
            }
        }

        private JwtHeader Header
        {
            get
            {
                return _header ??= new JwtHeader(
                    new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Passphrase)),
                        SecurityAlgorithms.HmacSha512
                        )
                    );
            }
        }

        public string GenerateToken(Customer customer)
        {
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                header: Header,
                payload: new JwtPayload(
                    issuer: null,
                    audience: null,
                    claims: new Claim[]
                    {
                        new Claim("Id", customer.Id.ToString()),
                        new Claim("LastName", customer.LastName),
                        new Claim("FirstName", customer.FirstName),
                        new Claim("Email", customer.Email)
                    },
                    notBefore: DateTime.Now,
                    expires: DateTime.Now.AddDays(1)
                    )
                );
            return $"{Prefixe}{Handler.WriteToken(jwtSecurityToken)}";
        }

        public Customer ValidateToken(string token)
        {
            Customer customer = null;

            token = token.Replace(Prefixe, "");
            JwtSecurityToken jwtSecurityToken = Handler.ReadJwtToken(token);
            DateTime now = DateTime.Now;
            if (jwtSecurityToken.ValidFrom <= now && jwtSecurityToken.ValidTo >= now)
            {
                JwtPayload payload = jwtSecurityToken.Payload;
                string compareToken = Handler.WriteToken(new JwtSecurityToken(Header, payload));

                if (token == compareToken)
                {
                    payload.TryGetValue("Id", out object id);
                    payload.TryGetValue("LastName", out object lastname);
                    payload.TryGetValue("FirstName", out object firstname);
                    payload.TryGetValue("Email", out object email);

                    customer = new Customer()
                    {
                        Id = int.Parse((string)id),
                        LastName = (string)lastname,
                        FirstName = (string)firstname,
                        Email = (string)email,
                    };
                }
            }

            return customer;
        }
    }
}
