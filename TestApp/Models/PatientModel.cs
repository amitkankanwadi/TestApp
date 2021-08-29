using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class PatientModel
    {
        public int PatientId { get; set; }
        public int TestId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string City { get; set; }
        public DateTime DOB { get; set; }
        [Required]
        public DateTime AdmissionDate { get; set; }
        [Required]
        public string Hospital { get; set; }
        [Required]
        public DateTime DischargeDate { get; set; }
        [Required]
        public double TotalAmount { get; set; }
    }

    public enum CityList 
    {
        Mumbai, Delhi, Bangalore, Hyderabad, Pune
    }

}