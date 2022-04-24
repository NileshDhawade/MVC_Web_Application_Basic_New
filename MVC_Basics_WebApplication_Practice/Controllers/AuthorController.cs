using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MVC_Basics_WebApplication_Practice.Models;

namespace MVC_Basics_WebApplication_Practice.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult AuthorList()
        {
            List<Author> list = new List<Author>();
            {
                new Author { authorId=111,authorName="Nilesh",authorBookName="Public Administraction" };
                new Author { authorId = 222, authorName = "Vikas", authorBookName = "Geography" };
                new Author { authorId = 333, authorName = "Rahul", authorBookName = "Polity" };
                new Author { authorId = 444, authorName = "vicky", authorBookName = "History" };
            };
            ViewBag.author = list;
            return View();
        }
    }
}
