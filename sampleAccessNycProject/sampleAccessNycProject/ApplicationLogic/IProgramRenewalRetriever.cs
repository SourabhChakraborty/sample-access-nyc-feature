using System;
using sampleAccessNycProject.Models;

namespace sampleAccessNycProject.ApplicationLogic
{
	public interface IProgramRenewalRetriever
	{
		public ProgramRenewalModel GetProgramRenewalInformation(long userId);
	}
}

