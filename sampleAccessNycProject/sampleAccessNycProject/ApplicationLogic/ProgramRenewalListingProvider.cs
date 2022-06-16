using System;
using Autofac.Features.Indexed;
using sampleAccessNycProject.Models;

namespace sampleAccessNycProject.ApplicationLogic
{
	public class ProgramRenewalListingProvider
	{
		private readonly IIndex<ProgramType, IProgramRenewalRetriever> _programRenewalRetrieverIndex;

		public ProgramRenewalListingProvider(IIndex<ProgramType, IProgramRenewalRetriever> programRenewalRetrieverIndex)
		{
			this._programRenewalRetrieverIndex = programRenewalRetrieverIndex;
		}

		public List<ProgramRenewalModel> GetProgramRenewalListing(long userId)
		{
			var programTypes = this.GetUsersProgramTypes(userId);

			return programTypes
				.Select(programType => this._programRenewalRetrieverIndex[programType].GetProgramRenewalInformation(userId))
				.ToList();
		}

		// Get the list of programs that the current user can apply to
		// or is in
		private List<ProgramType> GetUsersProgramTypes(long userId)
		{
			throw new NotImplementedException();
		}
	}
}

