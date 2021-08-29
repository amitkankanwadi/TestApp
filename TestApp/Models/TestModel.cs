using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class TestModel
    {
        public int TestId { get; set; }
        public int PatientId { get; set; }
        [Required]
        public string TestName { get; set; }
        [Required]
        public DateTime TestDate { get; set; }
        [Required]
        public double TestPrice { get; set; }
        [Required]
        public string TestResult { get; set; }
        [Required]
        public string DoctorRemarks { get; set; }
    }
}