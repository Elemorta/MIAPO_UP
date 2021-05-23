using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAPO_UP
{
    class Service_car
    {
        [Key]
        public int Service_car_id { get; set; }
        public int Car_id { get; set; }
        public string Date_begin {get; set;}
        public string Date_end { get; set; }

    }
}
