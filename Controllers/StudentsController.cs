using Chacha_project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chacha_project.Controllers
{
  
    public class StudentsController : Controller
    {
        private readonly StudentContext _db;
        public StudentsController(StudentContext db)
        {
            _db = db;
            
        }

        
        [HttpGet]
        public IActionResult  Index()//

        {
            var list = _db.Students.ToList(); 
            return View(list);
        }
        [HttpGet]
        public IActionResult  AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {

            _db.Students.Add(student);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
       
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var ChachaV = _db.Students.Where(a => a.Id == id).FirstOrDefault();
            return View(ChachaV);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {

            var ChachaV = _db.Students.Find(student.Id);
            if (ChachaV != null)
            {
                ChachaV.StudentName = student.StudentName;
                ChachaV.FatherName = student.FatherName;
                ChachaV.StudentRelation = student.StudentRelation;
                ChachaV.Email = student.Email;
                ChachaV.Religion = student.Religion;
                ChachaV.Nationality = student.Nationality;
                ChachaV.Gender = student.Gender;
                ChachaV.RegistrationNo = student.RegistrationNo;
                ChachaV.StudentCNIC = student.StudentCNIC;
                ChachaV.Domicile = student.Domicile;
                ChachaV.Phone = student.Phone;
                _db.Students.Update(ChachaV);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }

        [HttpGet]
        public IActionResult Delete(int id)

        {
            var ChachaV = _db.Students.Where(a => a.Id == id).FirstOrDefault();
            return View(ChachaV);
        }
        [HttpPost]
        public IActionResult Delete(Student student)

        {
            var ChachaV = _db.Students.Find(student.Id);
            if (ChachaV != null)
            {
                _db.Students.Remove(ChachaV);
                _db.SaveChanges();

            }
            else
            {

            }
            return RedirectToAction("index");
        }



    }
}

