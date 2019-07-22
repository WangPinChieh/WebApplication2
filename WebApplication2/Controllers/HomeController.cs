using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var moneyTemplateModel = new MoneyTemplateModel();
			var random = new Random();
			for (int j = 0; j < 50; j++)
			{
				moneyTemplateModel.DeaiDetails.Add(new MoneyDetail()
				{
					ID = j + 1,
					Amount = random.Next(10, 2000),
					Category = j % 2 != 0 ? "伙食" : "娛樂",
					Date = DateTime.Now
				});

			}
			return View(moneyTemplateModel);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}

	public class MoneyTemplateModel
	{
		public List<MoneyDetail> DeaiDetails { get; set; } = new List<MoneyDetail>();
	}

	public class MoneyDetail
	{
		public int ID { get; set; }
		public string Category { get; set; }
		public DateTime Date { get; set; }
		public decimal Amount { get; set; }

	}
}