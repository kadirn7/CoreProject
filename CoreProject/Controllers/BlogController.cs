﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm= new BlogManager (new EfBlogRepository ());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            var values=bm.GetBlogByID(id);
            return View(values);
        }
    }
}
