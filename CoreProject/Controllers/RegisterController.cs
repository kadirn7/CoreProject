﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager vm = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult result = wv.Validate(writer);
            if(result.IsValid) {
				writer.Status = true;
				writer.About = "Deneme test";
				vm.WriterAdd(writer);
				return RedirectToAction("Index", "Blog");
			}
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
    }
}
