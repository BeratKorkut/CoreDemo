﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetList()
        {
            return _messageDal.GetListAll();
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messageDal.GetListAll(x => x.MessageReceiver == p);
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message TGetByID(int id)
        {
            return _messageDal.GetByID(id);
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }

        public string CalculateTimeDifference(DateTime messageDate)
        {
            TimeSpan timeDifference = DateTime.Now - messageDate;

            // Farkın saat ve dakika olarak hesaplanması
            int hours = (int)timeDifference.TotalHours;
            int minutes = timeDifference.Minutes;

            // Farkı ifade eden metin oluşturulması
            string result = $"{hours} saat {minutes} dakika";

            return result;
        }
    }
}