using MapsTest.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MapsTest.Controllers
{
    public class MapController : ApiController
    {
        private MapsDbEntities1 db = new MapsDbEntities1();

        public HttpResponseMessage Get()
        {
            try
            {
                IEnumerable<markerLocation> markers = new List<markerLocation>();

                {
                    markers = db.markerLocations.ToList();
                    HttpResponseMessage response;
                    response = Request.CreateResponse(HttpStatusCode.OK, markers);
                    return response;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        public string saveMarker(MarkerViewModel marker)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    markerLocation Markerlocation = new markerLocation();
                    Markerlocation.markerID = Guid.NewGuid();
                    Markerlocation.Latitude = marker.Latitude;
                    Markerlocation.Longitude = marker.Longitude;
                    Markerlocation.Description = marker.Description;
                    Markerlocation.markerName = "abc";
                    Markerlocation.isActive = true;
                    Markerlocation.CreatedBy = User.Identity.GetUserId();
                    Markerlocation.CreatedDate = DateTime.Now;
                    db.markerLocations.Add(Markerlocation);
                    db.SaveChanges();

                    return "done";
                }

                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
