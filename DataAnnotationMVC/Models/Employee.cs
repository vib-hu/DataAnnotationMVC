using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace DataAnnotationMVC.Models
{
    public class Employee
    {
        [ScaffoldColumn(false)]
        public int id { get; set; }

        [Required(ErrorMessage="Please enter user name")]
        [ExcludeChar(@"/.,!@#$%^~*()_-+=`{}[]|\?><")]
        public string UserName { get; set; }

        [Required(ErrorMessage="Please enter first name")]
        [MinLength(3,ErrorMessage="First Name min length should be 3")]
        [ExcludeChar("/.,!@#$%")]
        [Display(Name="First name")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage="Please enter last name")]
        [ExcludeChar("/.,!@#$%")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage="Please enter lob")]
        [ExcludeChar("/.,!@#$%")]
        [Display(Name = "Lob")]
        public string Lob { get; set; }

        [CheckBoxValidtaion()]
        public bool IsChecked { get; set; }
    }
}