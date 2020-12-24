using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class Menu
    {
        public short MenuId { get; set; }
        public string MenuName { get; set; }
        public Guid OrgId { get; set; }
        public bool? IsActive { get; set; }
        public bool IsParent { get; set; }
        public short ParentId { get; set; }
        public short ResourceId { get; set; }
        public int ResourceActionId { get; set; }
        public short DisplayOrder { get; set; }
        public string MenuUrl { get; set; }
        public string Icons { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
