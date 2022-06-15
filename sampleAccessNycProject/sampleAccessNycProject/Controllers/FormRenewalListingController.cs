using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sampleAccessNycProject.Controllers
{
    public class FormRenewalListingController : Controller
    {
        // TODO: get a list of FormRenewalModel objects
        // for the current user
        [HttpGet("/form/metadata/list")]
        public IActionResult ListFormRenewals()
        {
            throw new NotImplementedException();
        }
    }
}

