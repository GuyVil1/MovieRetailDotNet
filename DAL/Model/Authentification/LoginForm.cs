using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    class LoginForm
    {
        [Required]
        [MaxLength(320]
        public string Email { get; set; }

        [Required]
        [MaxLength(320]
        public string Passwd { get; set; }
    }
}
