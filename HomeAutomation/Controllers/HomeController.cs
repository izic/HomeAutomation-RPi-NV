using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

using System.ServiceModel;

namespace HomeAutomation.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			var mvcName = typeof(Controller).Assembly.GetName ();
			var isMono = Type.GetType ("Mono.Runtime") != null;

			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData ["Runtime"] = isMono ? "Mono_Ivina" : ".NET";


			return View ();
		}

		public ActionResult TestButton ()
		{

			string name = "";
			var binding = new BasicHttpBinding ();
			var address = new EndpointAddress ("http://localhost:8090");
			var client = new Client.MyServiceClient (binding, address);

			client.Greet (name);

			return View ();
		}
	}
}

