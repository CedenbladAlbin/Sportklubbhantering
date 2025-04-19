using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EntityLayer
{
    internal class Members
    {
		[Key]
		public int member_ID { get; set; }

		public string member_name { get; set; }
		public Date Birthday { get; set; }
		public string phonenumber { get; set; }
		public string email { get; set; }
		public bool paymentstatus { get; set; }
	}
}
