using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapsTest.Models
{
    public class MarkerViewModel
    {
        public Guid markerID { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }
        public string markerName { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool isActive { get; set; }
        public DateTime updatedDate { get; set; }
        public string updatedBy { get; set; }
    }
}