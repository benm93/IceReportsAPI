using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceReportsAPI.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public int Rating { get; set; }
        public String Description { get; set; }
        public String Area { get; set; }
        public List<Picture> Pictures { get; set; }
        public List<Climb> Climbs { get; set; }
    }
}
