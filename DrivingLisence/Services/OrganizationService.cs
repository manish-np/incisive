using DrivingLisence.IServices;
using DrivingLisence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrivingLisence.Services
{
    public class OrganizationService : IOrganizationService
    {
        DrivingSchoolContext dBContext;

        public OrganizationService(DrivingSchoolContext _db)
        {
            dBContext = _db;
        }


        public IEnumerable<Organization> GetOrganization()
        {
            var organization = dBContext.Organization.ToList();
            return organization;
        }

        public Organization AddOrganization(Organization organization)
        {
            if (organization != null)
            {
                dBContext.Organization.Add(organization);
                return organization;
            }
            return null;
        }

        public Organization DeleteOrganization(string id)
        {
            throw new NotImplementedException();
        }

        public Organization GetOrganizationById(string id)
        {
            throw new NotImplementedException();
        }

        public Organization UpdateOrganization(Organization organization)
        {
            throw new NotImplementedException();
        }
    }
}
