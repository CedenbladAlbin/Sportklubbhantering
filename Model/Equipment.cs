using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Equipment
    {
        [Key]
        public int equipment_ID { get; set; }
   
        public string equipment_name { get; set; }
   
        public string category { get; set; }
        public int condition { get; set; }
        public int available_count { get; set; }


    }
}
