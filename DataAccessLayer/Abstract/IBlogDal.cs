using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal
    {
        List<Blog> ListAll();
        void Add(Blog blog);
        void Delete(Blog Blog);
        void Update(Blog Blog);
        
        Blog GetbyId(int id);

    }
}
