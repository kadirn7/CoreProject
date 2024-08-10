using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
	public class CommentController : Controller
	{
		CommentManager _commentManager = new CommentManager(new EfCommentRepository());

        public CommentController(CommentManager commentManager)
        {
            _commentManager = commentManager;
        }

        public IActionResult Index()
		{
			return View();

		}
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int blogId)
        {
			var values = _commentManager.Getlist( blogId);
			return PartialView(values);
		}
	}
}
