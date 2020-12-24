using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class Resources
    {
        public short ResourceId { get; set; }
        public short ModuleId { get; set; }
        public string ResourceName { get; set; }
        public string DisplayName { get; set; }
        public string ResourceDesc { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public Guid OrgId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
