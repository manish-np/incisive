using DrivingLisence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrivingLisence.IServices
{
    public interface IOrganizationService
    {
        IEnumerable<Organization> GetOrganization();
        Organization GetOrganizationById(string id);
        Organization AddOrganization(Organization organization);
        Organization UpdateOrganization(Organization organization);
        Organization DeleteOrganization(string id);
    }
}
