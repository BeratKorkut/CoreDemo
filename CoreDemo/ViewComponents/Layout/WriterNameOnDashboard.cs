using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Layout
{
    public class WriterNameOnDashboard : ViewComponent
    {
        private readonly IWriterService _writerService;

        public WriterNameOnDashboard(IWriterService writerService)
        {
            _writerService = writerService;
        }

        [Authorize]
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var userMail = User.Identity.Name;
            var writerName = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
            var writerImage = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterImage).FirstOrDefault();
            ViewBag.Name = writerName;
            ViewBag.Image = writerImage;
            return View();
        }
    }
}
