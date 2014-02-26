using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace Castle.MicroKernel
{
	[ContractClass(typeof(KernelContractClass))]
	public interface IKernel : IDisposable
	{
		IDependencyResolver Resolver { get; }
	}

	[ContractClassFor(typeof(IKernel))]
	[ExcludeFromCodeCoverage]
	internal abstract class KernelContractClass : IKernel
	{
		IDependencyResolver IKernel.Resolver
		{
			get
			{
				Contract.Ensures(Contract.Result<IDependencyResolver>() != null);
				throw new NotImplementedException();
			}
		}

		public abstract void Dispose();
	}
}
