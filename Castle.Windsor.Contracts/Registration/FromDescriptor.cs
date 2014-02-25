using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace Castle.MicroKernel.Registration
{
	public abstract class FromDescriptor : IRegistration
	{
		public FromDescriptor AllowMultipleMatches()
		{
			Contract.Ensures(Contract.Result<FromDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor BasedOn<T>()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor BasedOn(IEnumerable<Type> basedOn)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor BasedOn(params Type[] basedOn)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor BasedOn(Type basedOn)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor InNamespace(string @namespace)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor InNamespace(string @namespace, bool includeSubnamespaces)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor InSameNamespaceAs<T>()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor InSameNamespaceAs<T>(bool includeSubnamespaces) where T : class
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor InSameNamespaceAs(Type type)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor InSameNamespaceAs(Type type, bool includeSubnamespaces)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor Pick()
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}

		public BasedOnDescriptor Where(Predicate<Type> accepted)
		{
			Contract.Ensures(Contract.Result<BasedOnDescriptor>() != null);
			throw new NotImplementedException();
		}
	}
}
