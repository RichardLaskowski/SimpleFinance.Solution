using System.Collections.Generic;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.Domain.Budget.Models
{
	public class Budget : DomainModel
	{
		public int BudgetId { get => _id; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<BudgetCategory> Categories { get; set; }
		public List<Owner> Owners { get; set; }

		public Budget(
			int budgetId,
			string name,
			string description,
			List<BudgetCategory> categories,
			List<Owner> owners) : base(budgetId)
		{
			Name = name;
			Description = description;
			Categories = categories;
			Owners = owners;
		}
	}
}