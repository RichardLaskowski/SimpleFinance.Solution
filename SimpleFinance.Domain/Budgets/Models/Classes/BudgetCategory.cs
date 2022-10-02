using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SimpleFinance.Domain.Budgets.Models.Interfaces;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Budgets.Models
{
	public class BudgetCategory : DomainModel, IBudgetCategory
	{
		#region Fields

		private List<IBudgetItem> _budgetItems;

		#endregion

		#region Properties

		public int BudgetCategoryId => _id;
		public string Name { get; set; }
		public string Description { get; set; }
		public ReadOnlyCollection<IBudgetItem> BudgetItems { get; private set; }
		public decimal AllottedAmount { get; set; }
		public decimal Total => CalculateTotal();
		public DateTime Date { get; set; }

		#endregion

		#region Constructor

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

		public void AddItem(IBudgetItem budgetItem)
		{
			_budgetItems.Add(budgetItem);
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