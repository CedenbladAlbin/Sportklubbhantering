using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EquipmentLoan
    {
        [Key]
        public int EquipmentLoan_Id { get; set; }
        public int Equipment_Id { get; set; }
        public int Member_Id { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
