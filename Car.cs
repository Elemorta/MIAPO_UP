using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAPO_UP
{
    class Car
    {
        [Key]
        public int Car_id { get; set; }
        string FK_Car_status { get; set;}
        string Car_name { get; set; }

        public void EditCar( string CS, string CN)
        {

        }

        public void CreateCar( string Cs, string Cn)
        {

        }

    }
}
