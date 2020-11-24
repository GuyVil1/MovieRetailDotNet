using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Service
{
    interface IAuthService
    {
        CustomerService Login(string email, string passwd);
        int Register Customer()
    }
}
