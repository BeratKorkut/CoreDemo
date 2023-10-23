using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        private readonly INewsLetterService _newsletterService;

        public NewsLetterController(INewsLetterService newsletterService)
        {
            _newsletterService = newsletterService;
        }

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            _newsletterService.TAdd(p);
            return PartialView();
        }
    }
}
