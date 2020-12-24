using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class Province
    {
        public byte ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public string Capital { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
