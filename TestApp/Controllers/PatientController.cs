using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class PatientController : Controller
    {
        TestModel tModel = new TestModel();
        static IList<PatientModel> patientList = new List<PatientModel>
        {
            new PatientModel(){PatientId = 1, TestId = 1, FirstName = "Virat", LastName = "Sharma", Age = 31, City = "Mumbai", DOB = DateTime.Parse("01-10-1991"), AdmissionDate = DateTime.Parse("05-02-2021"), Hospital = "Bhaba Hospital", DischargeDate = DateTime.Parse("02-10-2021"), TotalAmount = 400}
        };
        // GET: Patient
        public ActionResult Index()
        {
            return View(patientList.OrderBy(p => p.PatientId));
        }

        public ActionResult Edit(int id)
        {
            var patient = patientList.FirstOrDefault(p => p.PatientId == id);
            return View(patient);
        }
        [HttpPost]
        public ActionResult Edit(PatientModel patient)
        {
            var pcnt = patientList.FirstOrDefault(p => p.PatientId == patient.PatientId);
            patientList.Remove(pcnt);
            patientList.Add(patient);

            return RedirectToAction("PatientList");
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PatientModel prod)
        {
            patientList.Add(prod);
            return RedirectToAction("Index");
        }

        [HttpPost] ActionResult CreateTest(TestModel test, int id)
        {
            var pTest = new TestModel() { TestId = test.TestId, PatientId = id,  TestName = test.TestName, TestDate = test.TestDate, TestPrice = test.TestPrice, TestResult = test.TestResult };
            return RedirectToAction("Index");
        }
    }
}