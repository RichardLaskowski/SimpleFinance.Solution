using System;
using CommunityToolkit.Diagnostics;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Budgets.Models;

/// <summary>
/// 
/// </summary>
public class BudgetItem : DomainModel, IBudgetItem
{
	#region Properties

	/// <summary>
	/// 
	/// </summary>
	public int BudgetItemId => _id;

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
	public decimal Amount { get; set; }

	/// <summary>
	/// 
	/// </summary>
	/// <value></value>
	public DateTime Date { get; set; }

	#endregion

	#region Constructor

	/// <summary>
	/// 
	/// </summary>
	/// <param name="budgetItemId"></param>
	/// <param name="name"></param>
	/// <param name="description"></param>
	/// <param name="amount"></param>
	/// <param name="date"></param>
	/// <returns></returns>
	public BudgetItem(int budgetItemId,
			string name,
			string description,
			decimal amount,
			DateTime date) : base(budgetItemId)
	{
		GuardBudgetItem(
			name,
			description,
			amount,
			date);

		Name = name;
		Description = description;
		Amount = amount;
		Date = date;
	}

	#endregion

	#region Public Methods

	#endregion

	#region Private Methods

	private void GuardBudgetItem(
		string name,
		string description,
		decimal amount,
		DateTime date)
	{
		try
		{
			GuardString(name, nameof(name));
			GuardString(description, nameof(description));
			GuardDecimal(amount, nameof(amount));
			Guard.IsOfType<DateTime>(Date, nameof(date));
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

	#endregion
}
