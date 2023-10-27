using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessage2Service _message2Service;

        public MessageController(IMessage2Service message2Service)
        {
            _message2Service = message2Service;
        }
        [AllowAnonymous]
        public IActionResult InBox()
        {
            int id = 2;
            var values = _message2Service.GetInboxListByWriter(id);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var values = _message2Service.TGetByID(id);
            return View(values);
        }
    }
}
