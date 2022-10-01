using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Common.Factories
{
	public abstract class AbstractFactory<T> : IAbstractFactory<T>
	{
		public abstract T Create();
	}
}