using SimpleFinance.Domain.Common.Models;

namespace SimpleFinance.Domain.Budgets.Models;

/// <summary>
/// 
/// </summary>
public class BudgetOwner : Owner, IBudgetOwner
{
	#region Properties

	/// <summary>
	/// 
	/// </summary>
	public int BudgetOwnerId => OwnerId;

	#endregion

	#region Constructor

	/// <summary>
	/// 
	/// </summary>
	/// <param name="budgetOwnerId"></param>
	/// <param name="firstName"></param>
	/// <param name="lastName"></param>
	/// <returns></returns>
	public BudgetOwner(
		int budgetOwnerId,
		string firstName,
		string lastName) : base(
			budgetOwnerId,
			firstName,
			lastName)
	{
		GuardBudgetOwner();
	}

	#endregion

	#region Private Methods
	private void GuardBudgetOwner()
	{

	}

	#endregion

}