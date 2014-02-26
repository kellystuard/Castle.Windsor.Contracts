using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using Castle.MicroKernel;

namespace Castle.Windsor
{
	[ContractClass(typeof(WindsorContainerContractClass))]
	public interface IWindsorContainer : IDisposable
	{
		IKernel Kernel { get; }

		T Resolve<T>();
		object Resolve(Type service);

		public T[] ResolveAll<T>();
	}

	[ContractClassFor(typeof(IWindsorContainer))]
	[ExcludeFromCodeCoverage]
	internal abstract class WindsorContainerContractClass : IWindsorContainer
	{
		IKernel IWindsorContainer.Kernel
		{
			get
			{
				Contract.Ensures(Contract.Result<IKernel>() != null);
				throw new NotImplementedException();
			}
		}

		T IWindsorContainer.Resolve<T>()
		{
			Contract.Ensures(Contract.Result<T>() != null);
			throw new NotImplementedException();
		}

		object IWindsorContainer.Resolve(Type service)
		{
			Contract.Ensures(Contract.Result<object>() != null);
			throw new NotImplementedException();
		}

		void IDisposable.Dispose()
		{
			throw new NotImplementedException();
		}

		T[] IWindsorContainer.ResolveAll<T>()
		{
			Contract.Ensures(Contract.Result<T[]>() != null);
			Contract.Ensures(Contract.ForAll(Contract.Result<T[]>(), c => c != null));
			throw new NotImplementedException();
		}
	}
}
