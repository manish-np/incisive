using System;
using System.Collections.Generic;

namespace DrivingLisence.Models
{
    public partial class Organization
    {
        public int Id { get; set; }
        public Guid OrgId { get; set; }
        public string OrgName { get; set; }
        public string PanNo { get; set; }
        public string VatNo { get; set; }
        public string PhoneNo { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public int? LocalBodyId { get; set; }
        public string Address1 { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string City { get; set; }
        public int? Country { get; set; }
        public DateTime? EstablishedDate { get; set; }
        public string LogoUrl { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }
        public int? NoOfEmployees { get; set; }
        public bool? IsActive { get; set; }
        public bool IsModified { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
