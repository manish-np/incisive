using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class Roles
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string DisplayName { get; set; }
        public string RoleDesc { get; set; }
        public Guid OrgId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsSysReserved { get; set; }
    }
}
