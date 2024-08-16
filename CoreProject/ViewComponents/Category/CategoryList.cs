﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager _categoryManager =new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values= _categoryManager.GetAllCategories();
            return View(values);
        }
    }
}
