using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TravelTrackEmpManegment.Models
{
    public class LogEmp
    {
        [Key]
        public int id { get; set; }

        [DisplayName(" Emp ID")]
        public string code { get; set; }

        [DisplayName("Name")]
        public string firstName { get; set; }
        [DisplayName("Email ID")]
        public string email { get; set; }
        [DisplayName("Mobile No")]
        public string phone { get; set; }
        [DisplayName("Password")]
        public string password { get; set; }
        [DisplayName("Role")]
        public string role { get; set; }

        [DisplayName("Is Active")]
        public bool empStatus { get; set; } // active / retire
    }
}