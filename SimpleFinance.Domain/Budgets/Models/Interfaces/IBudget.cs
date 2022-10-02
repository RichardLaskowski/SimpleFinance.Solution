using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Budgets.Models;

/// <summary>
/// 
/// </summary>
public interface IBudget
{
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    int BudgetId { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    ReadOnlyCollection<IBudgetCategory> BudgetCategories { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    ReadOnlyCollection<IBudgetOwner> BudgetOwners { get; }
}