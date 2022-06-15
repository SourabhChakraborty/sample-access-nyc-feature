using System;
using sampleAccessNycProject.Models;

namespace sampleAccessNycProject.ApplicationLogic
{
	public interface IFormRenewalRetriever
	{
		public FormRenewalModel GetFormRenewal(long userId);
	}
}

