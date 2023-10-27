using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic3 : ViewComponent
    {
        private readonly IBlogService _blogService;

        public Statistic3(IBlogService blogService)
        {
            _blogService = blogService;
        }
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
