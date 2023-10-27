using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        private readonly IMessage2Service _message2Service;

        public WriterMessageNotification(IMessage2Service message2Service)
        {
            _message2Service = message2Service;
        }

        public IViewComponentResult Invoke()
        {
            int id = 2;
            Context c = new Context();
            ViewBag.messages = c.Message2s.Where(x => x.MessageReceiverID == id).Count();

            var values = _message2Service.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
