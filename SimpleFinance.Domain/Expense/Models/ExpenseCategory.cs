using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Expense.Models;

/// <summary>
/// 
/// </summary>
public class ExpenseCategory : Category
{
    /// <summary>
    /// 
    /// </summary>
    public int ExpenseCategoryId => CategoryId;

    /// <summary>
    /// 
    /// </summary>
    public string CategoryName => Name;

    /// <summary>
    /// 
    /// </summary>
    public string CategoryDescription => Description;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="expenseCategoryId"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <returns></returns>
    public ExpenseCategory(
        int expenseCategoryId,
        string name,
        string description) : base(expenseCategoryId, name, description)
    {
    }
}