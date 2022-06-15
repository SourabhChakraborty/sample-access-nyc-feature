using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sampleAccessNycProject.ApplicationLogic;

namespace sampleAccessNycProject.Controllers
{
    public class ProgramRenewalListingController : Controller
    {
        private readonly ProgramRenewalListingProvider _programRenewalListingProvider;

        public ProgramRenewalListingController(ProgramRenewalListingProvider programRenewalListingProvider)
        {
            this._programRenewalListingProvider = programRenewalListingProvider;
        }

        [HttpGet, Route("/program/renewal/list")]
        public IActionResult ListProgramRenewals()
        {
            var userId = this.getCurrentUserId();
            var programRenewalListing = this._programRenewalListingProvider.GetProgramRenewalListing(userId);
            return this.Json(programRenewalListing);
        }

        // Get the ID of the current user. In an actual
        // application, this could be implemented in a separate class
        // using the current session
        private long getCurrentUserId()
        {
            throw new NotImplementedException();
        }
    }
}

