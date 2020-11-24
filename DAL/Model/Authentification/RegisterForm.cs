using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    class RegisterForm
    {
        [Required]
        [StringLength(50, Minimumlenght = 2)]
    }
}
