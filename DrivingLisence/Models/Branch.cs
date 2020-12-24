using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class Branch
    {
        public short BranchId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public Guid OrgId { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string FaxNo { get; set; }
        public string Website { get; set; }
        public string City { get; set; }
        public byte LocalBodyId { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
