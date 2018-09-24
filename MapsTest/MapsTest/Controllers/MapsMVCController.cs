using MapsTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapsTest.Controllers
{
    [Authorize]
    public class MapsMVCController : Controller
    {
            private MapsDbEntities1 db = new MapsDbEntities1();
            // GET: MapsMVC
            public ActionResult Index()
            {
                return View();
            }

            public ActionResult showMarkers()
            {
                try
                {
                    List<markerLocation> markersList = db.markerLocations.ToList();
                    return View(markersList);
                }
                catch (Exception ex)
                {
                    return Json(ex.Message);
                }
            }

            public ActionResult GetMarker()
            {
                return View();
            }
        }
}