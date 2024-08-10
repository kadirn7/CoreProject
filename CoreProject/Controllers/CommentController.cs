using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
		public PartialViewResult CommentListByBlog()
		{
			var values = _commentManager.Getlist();
			return PartialView(values);
		}
	}
}
