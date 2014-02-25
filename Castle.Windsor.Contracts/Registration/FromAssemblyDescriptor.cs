using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Reflection;

namespace Castle.MicroKernel.Registration
{
	public class FromAssemblyDescriptor : FromDescriptor
	{
		public FromAssemblyDescriptor IncludeNonPublicTypes()
		{
			Contract.Ensures(Contract.Result<FromAssemblyDescriptor>() != null);
			throw new NotImplementedException();
		}
	}
}
