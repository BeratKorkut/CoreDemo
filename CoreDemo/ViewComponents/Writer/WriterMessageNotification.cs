using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        private readonly IMessageService _messageService;

        public WriterMessageNotification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            ViewBag.messages = c.Messages.Count();
            string p;
            p = "deneme@gmail.com";
            var values = _messageService.GetInboxListByWriter(p);
            return View(values);
        }
    }
}
