using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class ResourcesActionRolesMap
    {
        public int Id { get; set; }
        public int ResourceActionId { get; set; }
        public int ResourceRoleId { get; set; }
    }
}
