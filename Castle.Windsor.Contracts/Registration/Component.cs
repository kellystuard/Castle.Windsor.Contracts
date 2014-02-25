using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Castle.MicroKernel.Registration
{
	public static class Component
	{
		public static ComponentRegistration<TService1> For<TService1, TService2, TService3, TService4>() where TService1 : class
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService1>>() != null);
			throw new NotImplementedException();
		}

		public static ComponentRegistration<TService1> For<TService1, TService2, TService3>() where TService1 : class
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService1>>() != null);
			throw new NotImplementedException();
		}

		public static ComponentRegistration<TService1> For<TService1, TService2>() where TService1 : class
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService1>>() != null);
			throw new NotImplementedException();
		}

		public static ComponentRegistration<TService> For<TService>() where TService : class
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService>>() != null);
			throw new NotImplementedException();
		}

		public static ComponentRegistration<TService1> For<TService1, TService2, TService3, TService4, TService5>() where TService1 : class
		{
			Contract.Ensures(Contract.Result<ComponentRegistration<TService1>>() != null);
			throw new NotImplementedException();
		}

		public static Predicate<Type> HasAttribute<TAttribute>(Predicate<TAttribute> filter) where TAttribute : Attribute
		{
			Contract.Ensures(Contract.Result<Predicate<Type>>() != null);
			throw new NotImplementedException();
		}

		public static bool HasAttribute<TAttribute>(Type type) where TAttribute : Attribute
		{
			throw new NotImplementedException();
		}

		public static bool IsCastleComponent(Type type)
		{
			throw new NotImplementedException();
		}

		public static Predicate<Type> IsInNamespace(string @namespace)
		{
			Contract.Ensures(Contract.Result<Predicate<Type>>() != null);
			throw new NotImplementedException();
		}

		public static Predicate<Type> IsInNamespace(string @namespace, bool includeSubnamespaces)
		{
			Contract.Ensures(Contract.Result<Predicate<Type>>() != null);
			throw new NotImplementedException();
		}

		public static Predicate<Type> IsInSameNamespaceAs<T>()
		{
			Contract.Ensures(Contract.Result<Predicate<Type>>() != null);
			throw new NotImplementedException();
		}

		public static Predicate<Type> IsInSameNamespaceAs<T>(bool includeSubnamespaces)
		{
			Contract.Ensures(Contract.Result<Predicate<Type>>() != null);
			throw new NotImplementedException();
		}

		public static Predicate<Type> IsInSameNamespaceAs(Type type)
		{
			Contract.Ensures(Contract.Result<Predicate<Type>>() != null);
			throw new NotImplementedException();
		}

		public static Predicate<Type> IsInSameNamespaceAs(Type type, bool includeSubnamespaces)
		{
			Contract.Ensures(Contract.Result<Predicate<Type>>() != null);
			throw new NotImplementedException();
		}
	}
}
