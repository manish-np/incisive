using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class Module
    {
        public short ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string DisplayName { get; set; }
        public string ModuleDesc { get; set; }
        public string RoutePath { get; set; }
        public Guid OrgId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
