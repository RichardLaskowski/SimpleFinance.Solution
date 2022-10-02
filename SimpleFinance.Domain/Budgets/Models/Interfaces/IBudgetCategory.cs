using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Budgets.Models.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBudgetCategory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        int BudgetCategoryId { get; }

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
        ReadOnlyCollection<IBudgetItem> BudgetItems { get; }
    }
}