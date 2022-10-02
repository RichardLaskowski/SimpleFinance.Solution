namespace SimpleFinance.Domain.Expense.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class VariableExpense : Expense
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public int VariableExpenseId { get => ExpenseId; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="variableExpenseId"></param>
        /// <returns></returns>
        public VariableExpense(int variableExpenseId) : base(variableExpenseId)
        {
        }
    }
}