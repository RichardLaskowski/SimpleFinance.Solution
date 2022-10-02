using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Expense.Models
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Expense : DomainModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        protected internal int ExpenseId { get => _id; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expenseId"></param>
        /// <returns></returns>
        protected Expense(int expenseId) : base(expenseId)
        {
        }
    }
}