using System;
namespace sampleAccessNycProject.Models
{
	public class ProgramRenewalModel
	{
		public DateOnly Deadline { get; }
		public ProgramType ProgramType { get; }

		// there could be more fields, like required documents
	}
}

