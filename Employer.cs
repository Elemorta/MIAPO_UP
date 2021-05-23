using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAPO_UP
{
   
    class Employer
    {
        ApplicationContext db;

        [Key]
        public int Employer_id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Postition { get; set; }
        public int Salary { get; set; }
        public int Expirience { get; set; }
        public int Userid { get; set; }


        //public Employer GetDataUser(string login, string password) { }
        //public Users CreateUser(string login, string password){Users authuser = null;authuser = db.Users.Where(b => b.login == login || b.password == password).FirstOrDefault();}
    }
}
