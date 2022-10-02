using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleFinance.Domain.Common.Models;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Expense.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ExpenseOwner : Owner
    {
        /// <summary>
        /// 
        /// </summary>
        public int ExpenseOwnerId => OwnerId;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expenseOwnerId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public ExpenseOwner(
            int expenseOwnerId,
            string firstName,
            string lastName) : base(
                expenseOwnerId,
                firstName,
                lastName)
        {

        }
    }
}