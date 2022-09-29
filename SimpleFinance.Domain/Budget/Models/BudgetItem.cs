namespace SimpleFinance.Domain.Budget
{
	public class BudgetItem
	{
		public int BudgetItemId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Amount { get; set; }

		public BudgetItem(int budgetItemId, string name, string description, decimal amount)
		{
			BudgetItemId = budgetItemId;
			Name = name;
			Description = description;
			Amount = amount;
		}
	}
}