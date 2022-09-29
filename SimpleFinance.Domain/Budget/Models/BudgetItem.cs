using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Budget.Models
{
	public class BudgetItem : DomainModel
	{
		#region Properties

		public int BudgetItemId => _id;
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Amount { get; set; }

		#endregion

		#region Constructors

		public BudgetItem(int budgetItemId,
				string name,
				string description,
				decimal amount) : base(budgetItemId)
		{
			Name = name;
			Description = description;
			Amount = amount;
		}

		#endregion
	}
}