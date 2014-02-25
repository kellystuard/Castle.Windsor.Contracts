using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Castle.MicroKernel.Registration
{
	public class ServiceDescriptor
	{
		public BasedOnDescriptor AllInterfaces()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor Base()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor DefaultInterfaces()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor FirstInterface()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor FromInterface()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor FromInterface(Type implements)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor Select(IEnumerable<Type> types)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor Select(ServiceDescriptor.ServiceSelector selector)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor Self()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public delegate IEnumerable<Type> ServiceSelector(Type type, Type[] baseTypes);
	}
}
