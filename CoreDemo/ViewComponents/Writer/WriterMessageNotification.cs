using BusinessLayer.Abstract;
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

        public IViewComponentResult Invoke(int id)
        {
            string p;
            p = "deneme@gmail.com";
            var values = _messageService.GetInboxListByWriter(p);
            return View(values);
        }
    }
}
