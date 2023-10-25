using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Notification
{
    public class SeeAllNotification : ViewComponent
    {
        private readonly INotificationService _notificationService;

        public SeeAllNotification(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _notificationService.GetList();
            return View(values);
        }
    }
}
