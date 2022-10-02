using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Budgets.Models.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBudgetItem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        int BudgetItemId { get; }

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
        decimal Amount { get; set; }
    }
}