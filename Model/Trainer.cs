using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Trainer
    {
        [Key]
        public int trainer_ID { get; set; }

        public string trainer_name { get; set; }
        public string specialization { get; set; }
        public string password { get; set; }
    }
}
