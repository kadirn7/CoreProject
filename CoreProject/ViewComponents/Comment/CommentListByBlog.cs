using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        private readonly CommentManager _commentManager;

        public CommentListByBlog()
        {
            _commentManager = new CommentManager(new EfCommentRepository());
        }

        public IViewComponentResult Invoke(int blogId)
        {
            var values = _commentManager.Getlist(blogId);
            return View(values);
        }
    }

}
