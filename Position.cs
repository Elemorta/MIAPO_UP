using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MIAPO_UP
{
    class Position
    {
        [Key]
        public int Position_id { get; set; }
        public string Position_name { get; set; }
    }
}
