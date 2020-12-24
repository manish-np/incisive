using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class DistrictList
    {
        public int DistrictId { get; set; }
        public int? ZoneId { get; set; }
        public string District { get; set; }
        public bool? IsInRemoteArea { get; set; }
        public int? ProvinceId { get; set; }
    }
}
