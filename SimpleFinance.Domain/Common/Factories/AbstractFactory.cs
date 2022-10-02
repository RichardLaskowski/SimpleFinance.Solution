using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Common.Factories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractFactory<T> : IAbstractFactory<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract T Create();
    }
}