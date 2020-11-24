using MovieDAL.Models;
using MovieDAL.Services;
using MovielRental.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovielRental.Models.Services
{
    public class AuthService : IAuthService
    {
        private CustomerService _customerService;
        public bool Check(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Login(string email, string passwd)
        {

            Customer bob = new Customer();
            bob.Email = email;
            bob.Passwd = passwd;
            return _customerService.GetCheck(bob);
        }

        public int Register(Customer customer)
        {
            return _customerService.Insert(customer);
                }

        public AuthService()
        {
            _customerService = new CustomerService();
        }
    }
}
