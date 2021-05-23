using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAPO_UP
{
    class Users
    {
        [Key]
        public int User_id { get; set; }
        public string User_login { get; set; }
        public string User_password { get; set; }
    }
}
