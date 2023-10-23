using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
		private readonly IWriterService _writerService;

		public RegisterController(IWriterService writerService)
		{
			_writerService = writerService;
		}

		[HttpGet]
        public IActionResult Index()
        {
            return View();
		}
		[HttpPost]
		public IActionResult Index(Writer w)
		{
			WriterValidator wv = new WriterValidator();
			ValidationResult result = wv.Validate(w);
			if(result.IsValid)
            {
                w.WriterStatus = true;
                w.WriterAbout = "Deneme Test";
                _writerService.TAdd(w);
                return RedirectToAction("Index", "Blog");
            }
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();

		}
	}
}
