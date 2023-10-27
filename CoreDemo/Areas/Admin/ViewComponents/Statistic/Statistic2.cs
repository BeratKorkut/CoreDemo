using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {            
            ViewBag.v1 = c.Blogs.OrderByDescending(x => x.BlogTitle).Select(x => x.BlogTitle).Take(1).FirstOrDefault(); 
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();
            var writerID = c.Blogs.OrderByDescending(x=>x.BlogID).Select(x=>x.WriterID).Take(1).FirstOrDefault();
            ViewBag.v4 = c.Writers.Where(x=>x.WriterID == writerID).Select(x=>x.WriterName).FirstOrDefault();
            return View();
        }
    }
}
