using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRApplicationAr.Models
{
    /// <summary>
    /// Employee class that have name , department , isActive
    /// </summary>
    public class Employee
    {

        //name
        [Required(ErrorMessage ="Please enter name")]
        [StringLength(maximumLength:10,MinimumLength =2)]
        public string employeeName { get; set; }
		//department
		[Required(ErrorMessage ="Please select department")]
		public string department { get; set; }
        //isActive
        public bool isActive { get; set; }
        //email property
        [Required(ErrorMessage = "Should valid email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        //jopTitle property
        [DataType(DataType.Text)]
		public string jopTitle { get; set; }
		//Datetime property
        [DataType(DataType.Date)]
		public string DateTime { get; set; }
    }
}
