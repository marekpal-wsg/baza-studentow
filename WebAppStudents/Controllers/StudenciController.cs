using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiStudents.Models;

namespace WebAppStudents.Controllers
{
    public class StudenciController : Controller
    {
        // GET: Studenci
        public ActionResult Index()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Album = 1, BirthDate = new DateTime(2000, 1, 1), Id = 1, FirstName = "Adam", LastName = "Pierwszy" });
            students.Add(new Student() { Album = 2, BirthDate = new DateTime(2000, 1, 1), Id = 2, FirstName = "Bartosz", LastName = "Drugi" });
            
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