using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class UserRoles
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public Guid OrgId { get; set; }
    }
}
