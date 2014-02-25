using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace Castle.MicroKernel.Registration
{
	public class ComponentRegistration<TService> : IRegistration where TService : class
	{
		public ComponentRegistration<TService> ImplementedBy<TImpl>() where TImpl : TService
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}

		public ComponentRegistration<TService> ImplementedBy(Type type)
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}

		public ComponentRegistration<TService> Instance(TService instance)
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}

		public ComponentRegistration<TService> LifestylePerThread()
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}

		public ComponentRegistration<TService> LifestylePerWebRequest()
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}

		public ComponentRegistration<TService> LifestylePooled(int? initialSize = null, int? maxSize = null)
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}

		public ComponentRegistration<TService> LifestyleScoped(Type scopeAccessorType = null)
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}

		public ComponentRegistration<TService> LifestyleSingleton()
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}

		public ComponentRegistration<TService> LifestyleTransient()
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}

		public ComponentRegistration<TService> Named(string name)
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}

		public ComponentRegistration<TService> NamedAutomatically(string name)
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}

		public ComponentRegistration<TService> UsingFactory<TFactory, TServiceImpl>(Converter<TFactory, TServiceImpl> factory) where TServiceImpl : TService
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}

		public ComponentRegistration<TService> UsingFactoryMethod<TImpl>(Func<TImpl> factoryMethod, bool managedExternally = false) where TImpl : TService
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}
	}
}
