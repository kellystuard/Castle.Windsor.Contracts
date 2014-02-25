using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace Castle.MicroKernel.Registration
{
	public class BasedOnDescriptor : IRegistration
	{
		public ServiceDescriptor WithService
		{
			get
			{
				Contract.Ensures(Contract.Result<ServiceDescriptor>() != null);
				throw new NotImplementedException();
			}
		}
		public FromDescriptor AllowMultipleMatches()
		{
			Contract.Ensures(Contract.Result<FromDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor If(Predicate<Type> ifFilter)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor LifestylePerThread()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor LifestylePerWebRequest()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor LifestylePooled(int? initialSize = null, int? maxSize = null)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor LifestyleScoped()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor LifestyleScoped(Type scopeAccessorType)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor LifestyleSingleton()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor LifestyleTransient()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor OrBasedOn(Type basedOn)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor Unless(Predicate<Type> unlessFilter)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor WithServiceAllInterfaces()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor WithServiceBase()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor WithServiceDefaultInterfaces()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor WithServiceFirstInterface()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor WithServiceFromInterface()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor WithServiceFromInterface(Type implements)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor WithServices(IEnumerable<Type> types)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor WithServiceSelf()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}
	}
}
