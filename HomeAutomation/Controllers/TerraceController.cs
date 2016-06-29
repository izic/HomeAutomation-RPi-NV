using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

using System.ServiceModel;

namespace HomeAutomation.Controllers
{
	public class TerraceController : Controller
	{
		public ActionResult Index ()
		{
			return View ();
		}

		public ActionResult StartWatering (int? interval)
		{	
			
			return View ();
		}

		public ActionResult StopWatering ()
		{	
			return View ();
		}


		public ActionResult ReadWateringState ()
		{	
			@ViewData ["WateringState"] = 100;
			return View ();
		}

		public ActionResult CheckWaterTankLevel ()
		{	
			@ViewData ["WaterTankLevel"] = 50;
			return View ();
		}

	}
}

