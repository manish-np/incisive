using DrivingLisence.IServices;
using DrivingLisence.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrivingLisence.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly IOrganizationService organizationService;

        public OrganizationController(IOrganizationService organization)
        {
            organizationService = organization;
        }

        [HttpGet]
        public IEnumerable<Organization> GetOrganizations()
        {
            return organizationService.GetOrganization();
        }

        [HttpPost]
        public Organization AddOrganization(Organization organization)
        {

            return organizationService.AddOrganization(organization);
        }


    }
}
