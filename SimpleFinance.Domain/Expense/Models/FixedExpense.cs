using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Expense.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class FixedExpense : Expense
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public int FixedExpenseId { get => ExpenseId; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fixedExpenseId"></param>
        /// <returns></returns>
        public FixedExpense(int fixedExpenseId) : base(fixedExpenseId)
        {
        }
    }
}