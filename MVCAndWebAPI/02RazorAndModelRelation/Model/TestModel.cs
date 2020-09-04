using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _02RazorAndModelRelation.Model
{
    public class TestModel : PageModel
    {
        [BindProperty]
        public string ProductName { get; set; }

        [BindProperty]
        public DateTime ProductDate { get; set; }

        [BindProperty]
        public Guid ProductID { get; set; }

        [BindProperty]
        public string ProductFamily { get; set; }

        public void OnGet()
        {
            ProductID = Guid.NewGuid();
            ProductName = "<未知产品>";
            ProductDate = DateTime.Today;
            ProductFamily = "<未知分类>";
        }

        public void OnPost()
        {
            ViewData["msg"] = "恭喜提交成功";
        }
    }
}