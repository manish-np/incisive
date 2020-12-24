using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string OrgId { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string MobileNo { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public short AccesFailedCount { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsEmployee { get; set; }
        public DateTime? LastBlockedDate { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
