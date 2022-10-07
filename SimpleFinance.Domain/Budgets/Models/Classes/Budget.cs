using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using SimpleFinance.Domain.Common.Enums;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Budgets.Models
{
	/// <summary>
	/// 
	/// </summary>
	public class Budget : DomainModel, IBudget
	{
		#region Constants

		private const int DEFAULT_ID = 0;
		private const string DEFAULT_CATEGORY_DESCRIPTION = "Enter a category description.";
		private const string DEFAULT_CATEGORY_NAME = "New Category";
		private const decimal DEFAULT_CATEGORY_ALLOTED_AMOUNT = 0;
		private const Month DEFAULT_CATEGORY_MONTH = Month.January;
		private const string DEFAULT_BUDGET_NAME = "New Budget";
		private const string DEFAULT_BUDGET_DESCRIPTION = "Enter a budget description.";

		#endregion

		#region Fields

		private List<IBudgetCategory> _budgetCategories;
		private List<IBudgetOwner> _budgetOwners;

		#endregion

		#region Properties

		/// <summary>
		/// 
		/// </summary>
		/// <value></value>
		public int BudgetId { get => _id; }

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
		public ReadOnlyCollection<IBudgetCategory> BudgetCategories { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		/// <value></value>
		public ReadOnlyCollection<IBudgetOwner> BudgetOwners { get; private set; }

		#endregion

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		/// <param name="budgetId"></param>
		/// <param name="name"></param>
		/// <param name="description"></param>
		/// <param name="budgetCategories"></param>
		/// <param name="budgetOwners"></param>
		/// <returns></returns>
		public Budget(
				int budgetId,
				string name,
				string description,
				List<IBudgetCategory> budgetCategories,
				List<IBudgetOwner> budgetOwners) : base(budgetId)
		{
			GuardBudget(
				name,
				description,
				budgetCategories,
				budgetOwners);

			Name = name;
			Description = description;

			_budgetCategories = budgetCategories;
			_budgetOwners = budgetOwners;

			BudgetCategories = new ReadOnlyCollection<IBudgetCategory>(_budgetCategories);
			BudgetOwners = new ReadOnlyCollection<IBudgetOwner>(_budgetOwners);
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// Creates a new budget with default values.
		/// </summary>
		/// <returns>Budget</returns>
		public static Budget Create()
		{
			int id = DEFAULT_ID;
			string name = DEFAULT_BUDGET_NAME;
			string description = DEFAULT_BUDGET_DESCRIPTION;

			List<IBudgetCategory> categories = new List<IBudgetCategory>();
			List<IBudgetOwner> owners = new List<IBudgetOwner>();

			Budget emptyBudget = new Budget(
				id,
				name,
				description,
				categories,
				owners);

			return emptyBudget;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="description"></param>
		/// <returns></returns>
		public static Budget Create(string name, string description)
		{
			int id = DEFAULT_ID;

			List<IBudgetCategory> categories = new List<IBudgetCategory>();
			List<IBudgetOwner> owners = new List<IBudgetOwner>();

			Budget emptyBudget = new Budget(
				id,
				name,
				description,
				categories,
				owners);

			return emptyBudget;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="description"></param>
		/// <param name="allotedAmount"></param>
		/// <param name="month"></param>
		public void CreateNewCategory(
			string name = DEFAULT_CATEGORY_NAME,
			string description = DEFAULT_CATEGORY_DESCRIPTION,
			decimal allottedAmount = DEFAULT_CATEGORY_ALLOTED_AMOUNT,
			Month month = DEFAULT_CATEGORY_MONTH)
		{
			int id = DEFAULT_ID;
			List<IBudgetItem> items = new List<IBudgetItem>();

			BudgetCategory newCategory = new BudgetCategory(id, name, description, allottedAmount, month, items);

			_budgetCategories.Add(newCategory);
		}

		public void EditCategory(BudgetCategory updateCategory) { }
		public void DeleteCategory(BudgetCategory deletionCategory) { }

		#endregion

		#region Private Methods
		private void GuardBudget(
			string name,
			string description,
			List<IBudgetCategory> budgetCategories,
			List<IBudgetOwner> budgetOwners)
		{
			try
			{
				GuardString(name, nameof(name));
				GuardString(description, nameof(description));
				GuardCollection<IBudgetCategory>(budgetCategories, nameof(budgetCategories));
				GuardCollection<IBudgetOwner>(budgetOwners, nameof(budgetOwners));
			}
			catch (ArgumentException innerException)
			{
				string message = innerException.Message;
				throw new ArgumentException(message, innerException);
			}
		}

		#endregion
	}
}