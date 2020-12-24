using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class ResourcesAction
    {
        public int ResourceActionId { get; set; }
        public Guid ResourceActionCode { get; set; }
        public short ResourceId { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string DisplayName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
