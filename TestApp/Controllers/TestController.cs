using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Models;

namespace Test.Controllers
{
    public class TestController : Controller
    {
        public static IList<TestModel> testList = new List<TestModel>
        {
            new TestModel(){TestId = 1, PatientId = 1, TestName = "Covid-19", TestDate = DateTime.Parse("15-03-2019"), TestPrice = 400, TestResult = "Negetive", DoctorRemarks = "Test Remarks"}
        };
        // GET: Test
        public ActionResult Index()
        {
            return View(testList.OrderBy(t => t.TestId));
        }

        public ActionResult Edit(int id)
        {
            var test = testList.FirstOrDefault(t => t.TestId == id);
            return View(test);
        }
        [HttpPost]
        public ActionResult Edit(TestModel test)
        {
            var tst = testList.FirstOrDefault(t => t.TestId == test.TestId);
            testList.Remove(tst);
            testList.Add(test);

            return RedirectToAction("Index");
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var test = testList.FirstOrDefault(t=> t.TestId == id);
            testList.Remove(test);
            return View("Index", testList);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(TestModel prod)
        {
            testList.Add(prod);
            return RedirectToAction("Index");
        }
    }
}