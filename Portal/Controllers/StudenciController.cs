using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using WebApiStudents.Models;

namespace Portal.Controllers
{
    public class StudenciController : Controller
    {
        // GET: Studenci
        public ActionResult Index()
        {
            #region Test z obiektami dodanymi z ręki
            //List<Student> students = new List<Student>();
            //students.Add(new Student()
            //{
            //    Album = 111,
            //    BirthDate = new DateTime(2000, 1, 1),
            //    FirstName = "Pierwszy",
            //    LastName = "Student",
            //    Id = 1
            //});

            //students.Add(new Student()
            //{
            //    Album = 222,
            //    BirthDate = new DateTime(1999, 1, 1),
            //    FirstName = "Druga",
            //    LastName = "Studentka",
            //    Id = 2
            //});
            #endregion

            RestClient client = new RestClient("https://localhost:5001/api");
            RestRequest request = new RestRequest("studenci", Method.GET, DataFormat.Json);
            IRestResponse<IEnumerable<Student>> response = client.Execute<IEnumerable<Student>>(request);

            IEnumerable<Student> students = response.Data;

            return View(students);
        }

        // GET: Studenci/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Studenci/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Studenci/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                Student student = new Student();
                student.FirstName = collection["FirstName"];
                student.LastName = collection["LastName"];
                student.Album = int.Parse(collection["Album"]);
                student.BirthDate = DateTime.Parse(collection["BirthDate"]);

                RestClient client = new RestClient("https://localhost:5001/api");
                RestRequest request = new RestRequest("studenci", Method.POST, DataFormat.Json);
                request.AddJsonBody(student);
                var response = client.Post<Student>(request);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Studenci/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Studenci/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Studenci/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Studenci/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}