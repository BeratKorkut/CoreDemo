using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        private readonly INotificationService _notificationService;

        public NotificationManager(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public List<Notification> GetList()
        {
            return _notificationService.GetList();
        }

        public void TAdd(Notification t)
        {
            _notificationService.TAdd(t);
        }

        public void TDelete(Notification t)
        {
            _notificationService.TDelete(t);
        }

        public Notification TGetByID(int id)
        {
            return _notificationService.TGetByID(id);
        }

        public void TUpdate(Notification t)
        {
            _notificationService.TUpdate(t);
        }
    }
}
