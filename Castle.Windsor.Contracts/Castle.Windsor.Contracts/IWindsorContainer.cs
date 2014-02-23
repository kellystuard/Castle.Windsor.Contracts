using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace Castle.Windsor
{
	[ContractClass(typeof(WindsorContainerContractClass))]
	public interface IWindsorContainer : IDisposable
	{
		T Resolve<T>();
		object Resolve(Type service);
	}

	[ContractClassFor(typeof(IWindsorContainer))]
	[ExcludeFromCodeCoverage]
	internal abstract class WindsorContainerContractClass : IWindsorContainer
	{
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
	}
}
