using System;
using System.Collections.Generic;

namespace LavenderMaster.Models
{
    public partial class Stations
    {
        public int Id { get; set; }
        public string Pbl { get; set; }
        public string Plant { get; set; }
        public string Bu { get; set; }
        public string Name { get; set; }
        public string IpSim { get; set; }
        public string IpBo { get; set; }
        public string Content { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
