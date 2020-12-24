using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class ResourcesRoles
    {
        public int ResourceRoleId { get; set; }
        public short ResourceId { get; set; }
        public Guid RoleId { get; set; }
    }
}
