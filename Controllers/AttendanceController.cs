using Chacha_project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chacha_project.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly StudentContext _context;
        public AttendanceController(StudentContext context)
        {
            _context = context;
        }
        public IActionResult Index()

        {
            var List = _context.Attendances.ToList();
            return View(List);

        }
        [HttpGet]
        public IActionResult AddAttendance()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAttendance(Attendance attendance)
        {
            _context.Attendances.Add(attendance);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var ChachaV = _context.Attendances.Where(a => a.AttendenceId ==id).FirstOrDefault();
            return View(ChachaV);
        }
        [HttpPost]
        public IActionResult Edit(Attendance attendance)
        {

            var Mamo_U = _context.Attendances.Find(attendance.AttendenceId);
            if (Mamo_U != null)
            {
                Mamo_U.AttendenceId = attendance.AttendenceId;
                Mamo_U.Present = attendance.Present;
                Mamo_U.Absent = attendance.Absent;
                Mamo_U.Leaves = attendance.Leaves;
                Mamo_U.EnterTime= attendance.EnterTime;
            
                _context.Attendances.Update(Mamo_U);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult Delete(int id)

        {
            var Mamo_U = _context.Attendances.Where(a => a.AttendenceId == id).FirstOrDefault();
            return View(Mamo_U);
        }
        [HttpPost]
        public IActionResult Delete(Attendance attendance)

        {
            var Mamo_U = _context.Attendances.Find(attendance.AttendenceId);
            if (Mamo_U != null)
            {
                _context.Attendances.Remove(Mamo_U);
                _context.SaveChanges();

            }
            else
            {

            }
            return RedirectToAction("index");
        }
        public IActionResult AttendanceAdd()
        {
            return View();
        }


    }
}
