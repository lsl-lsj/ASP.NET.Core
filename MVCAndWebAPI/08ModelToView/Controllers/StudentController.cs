using System;
using System.Collections.Generic;
using _08ModelToView.Models;
using Microsoft.AspNetCore.Mvc;

namespace _08ModelToView.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult AllStudents()
        {
            List<Student> stus = new List<Student>
            {
                new Student
                {
                    ID = Guid.NewGuid(),
                    Name = "zhangsan",
                    Age = 10,
                    Course  = "C"
                },
                new Student
                {
                    ID = Guid.NewGuid(),
                    Name = "lisi",
                    Age = 12,
                    Course  = "C++"
                },
                new Student
                {
                    ID = Guid.NewGuid(),
                    Name = "wangwu",
                    Age = 13,
                    Course  = "C#"
                }
            };
            
            ViewData.Model = stus;
            return View();
        }
    }
}