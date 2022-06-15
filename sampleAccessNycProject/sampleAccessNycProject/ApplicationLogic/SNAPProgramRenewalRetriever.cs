using System;
using sampleAccessNycProject.Models;

namespace sampleAccessNycProject.ApplicationLogic
{
	public class SNAPProgramRenewalRetriever : IProgramRenewalRetriever
	{
		public SNAPProgramRenewalRetriever()
		{
		}

		public ProgramRenewalModel GetProgramRenewalInformation(long userId)
		{
			return this.callSNAP_API(userId).ToProgramRenewalModel();
		}

		private SNAP_APIResult callSNAP_API(long userId)
        {
			throw new NotImplementedException();
        }
	}

	// The shape of the object that the SNAP API returns
	internal class SNAP_APIResult
    {
		// The class could contain some fields corresponding to
		// required forms and deadlines

		// Converts the current object to a ProgramRenewalModel
		internal ProgramRenewalModel ToProgramRenewalModel()
        {
			// The ProgramType of the result would be ProgramType.SNAP
			throw new NotImplementedException();
        }
    }
}

