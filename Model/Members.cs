using System.ComponentModel.DataAnnotations;

namespace Model
{
    internal class Members
    {
		[Key]
		public int member_ID { get; set; }

		public string member_name { get; set; }
		public date Birthday { get; set; }
		public string phonenumber { get; set; }
		public string email { get; set; }
		public bool paymentstatus { get; set; }
	}
}
