using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        private readonly IBlogService _blogService;

        public Statistic1(IBlogService blogService)
        {
            _blogService = blogService;
        }
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _blogService.GetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();

            string api = "f282971591754e01e9d647ecf9853c45";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=kocaeli&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.derece = document.Descendants("temperature").ElementAt(0).Attribute("value").Value; 
            ViewBag.il = document.Descendants("city").ElementAt(0).Attribute("name").Value; 
            ViewBag.hava = document.Descendants("weather").ElementAt(0).Attribute("value").Value; 

            return View();
        }
    }
}
