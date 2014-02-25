using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Reflection;

namespace Castle.MicroKernel.Registration
{
	public static class Classes
	{
		public static FromTypesDescriptor From(IEnumerable<Type> types)
		{
			Contract.Ensures(Contract.Result<FromTypesDescriptor>() != null);
			throw new NotImplementedException();
		}

		public static FromTypesDescriptor From(params Type[] types)
		{
			Contract.Ensures(Contract.Result<FromTypesDescriptor>() != null);
			throw new NotImplementedException();
		}

		public static FromAssemblyDescriptor FromAssembly(Assembly assembly)
		{
			Contract.Ensures(Contract.Result<FromAssemblyDescriptor>() != null);
			throw new NotImplementedException();
		}

		public static FromAssemblyDescriptor FromAssemblyContaining<T>()
		{
			Contract.Ensures(Contract.Result<FromAssemblyDescriptor>() != null);
			throw new NotImplementedException();
		}

		public static FromAssemblyDescriptor FromAssemblyContaining(Type type)
		{
			Contract.Ensures(Contract.Result<FromAssemblyDescriptor>() != null);
			throw new NotImplementedException();
		}

		public static FromAssemblyDescriptor FromAssemblyInDirectory(AssemblyFilter filter)
		{
			Contract.Ensures(Contract.Result<FromAssemblyDescriptor>() != null);
			throw new NotImplementedException();
		}

		public static FromAssemblyDescriptor FromAssemblyInThisApplication()
		{
			Contract.Ensures(Contract.Result<FromAssemblyDescriptor>() != null);
			throw new NotImplementedException();
		}

		public static FromAssemblyDescriptor FromAssemblyNamed(string assemblyName)
		{
			Contract.Ensures(Contract.Result<FromAssemblyDescriptor>() != null);
			throw new NotImplementedException();
		}

		public static FromAssemblyDescriptor FromThisAssembly()
		{
			Contract.Ensures(Contract.Result<FromAssemblyDescriptor>() != null);
			throw new NotImplementedException();
		}
	}
}
