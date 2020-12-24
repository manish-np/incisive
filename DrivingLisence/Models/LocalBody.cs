using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class LocalBody
    {
        public int Id { get; set; }
        public int DistrictRefId { get; set; }
        public string Name { get; set; }
        public string NameNepali { get; set; }
        public int? Type { get; set; }
    }
}
