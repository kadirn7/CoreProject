﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        
       

        public void Delete(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return c.Categories.ToList();
        }

       
        public Category GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public void Insert(Category t)
        {
            c.Add(t);
            c.SaveChanges();
        }

       

        public void Update(Category category)
        {
            c.Update(category);
            c.SaveChanges();

        }
    }
}
