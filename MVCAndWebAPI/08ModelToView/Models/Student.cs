using System;
using Microsoft.AspNetCore.Mvc;

namespace _08ModelToView.Models
{
    public class Student
    {
        [BindProperty]
        public Guid ID { get; set; }
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public int Age { get; set; }
        [BindProperty]
        public string Course { get; set; }
    }
}