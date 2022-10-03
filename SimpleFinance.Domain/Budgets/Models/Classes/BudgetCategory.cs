using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SimpleFinance.Domain.Common.Enums;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Budgets.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class BudgetCategory : DomainModel, IBudgetCategory
    {
        #region Fields

        private const string DEFAULT_ITEM_NAME = "New Item";
        private const string DEFAULT_ITEM_DESCRIPTION = "Enter an item description.";
        private const decimal DEFAULT_ITEM_AMOUNT = 0;
        private const int DEFAULT_ID = 0;
        private List<IBudgetItem> _budgetItems;

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public int BudgetCategoryId => _id;
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public decimal AllottedAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public Month Month { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public decimal Total => CalculateTotal();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int ItemCount => BudgetItems.Count();
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public ReadOnlyCollection<IBudgetItem> BudgetItems { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="budgetCategoryId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="budgetItems"></param>
        /// <returns></returns>
        public BudgetCategory(
                int budgetCategoryId,
                string name,
                string description,
                List<IBudgetItem> budgetItems) : base(budgetCategoryId)
        {
            GuardBudgetCategory(name, description, budgetItems);

            Name = name;
            Description = description;

            _budgetItems = budgetItems;

            BudgetItems = new ReadOnlyCollection<IBudgetItem>(_budgetItems);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="budgetItem"></param>
        public void AddItem(IBudgetItem budgetItem)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        public void CreateNewItem(
            string name = DEFAULT_ITEM_NAME,
            string description = DEFAULT_ITEM_DESCRIPTION,
            decimal amount = DEFAULT_ITEM_AMOUNT)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemName"></param>
        public void RemoveItem(string itemName)
        {

        }

        #endregion

        #region Private Methods

        private void GuardBudgetCategory(string name, string description, List<IBudgetItem> budgetItems)
        {
            try
            {
                GuardString(name, nameof(name));
                GuardString(description, nameof(description));
                GuardCollection<IBudgetItem>(budgetItems, nameof(budgetItems));

            }
            catch (ArgumentNullException innerException)
            {
                throw new ArgumentNullException(innerException.Message, innerException);
            }
            catch (ArgumentOutOfRangeException innerException)
            {
                throw new ArgumentOutOfRangeException(innerException.Message, innerException);
            }
            catch (ArgumentException innerException)
            {
                throw new ArgumentException(innerException.Message, innerException);
            }
        }

        private decimal CalculateTotal()
        {
            decimal result = (from item in BudgetItems select item.Amount).Sum();
            return result;
        }

        #endregion
    }
}