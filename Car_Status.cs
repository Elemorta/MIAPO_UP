using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAPO_UP
{
    class Car_Status
    {
        [Key]
        public int Status_id { get; set; }
        public string Status_name { get; set; }
    }
}
