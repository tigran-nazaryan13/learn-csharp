using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentDashboard.Models;
using System.Collections.Generic;

namespace StudentDashboard.Pages
{
    public class IndexModel : PageModel
    {
        public static List<Student> Students = new();

        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public int Age { get; set; }
        [BindProperty]
        public int Grade { get; set; }
        [BindProperty]
        public string Type { get; set; } // Student or Honors

        public void OnGet() {}

        public IActionResult OnPostAdd()
        {
            Student student = Type == "Honors"
                ? new HonorsStudent { Name = Name, Age = Age, Grade = Grade }
                : new Student { Name = Name, Age = Age, Grade = Grade };

            Students.Add(student);
            return RedirectToPage();
        }

        public IActionResult OnPostDelete(int index)
        {
            if (index >= 0 && index < Students.Count)
                Students.RemoveAt(index);
            return RedirectToPage();
        }
    }
}
