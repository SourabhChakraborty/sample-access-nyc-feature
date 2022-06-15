using System;
using sampleAccessNycProject.Models;

namespace sampleAccessNycProject.ApplicationLogic
{
	public interface IProgramRenewalRetriever
	{
		public ProgramRenewalModel GetProgramRenewal(long userId);
	}
}

