using System;
using Autofac;
using sampleAccessNycProject.ApplicationLogic;
using sampleAccessNycProject.Models;

namespace sampleAccessNycProject.Startup
{
	public class Startup
	{
		public void ConfigureContainer(ContainerBuilder builder)
		{
			builder.RegisterType<SNAPProgramRenewalRetriever>().Keyed<ProgramType>(ProgramType.SNAP);
		}
	}
}

