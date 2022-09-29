using System.Linq;
using Bogus;
using SimpleFinance.Domain.Budget.Models;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.ConsoleUI
{
	internal class Program
	{
		private const int Count = 10;

		static void Main(string[] args)
		{
			int budgetItemIds = 0;
			int budgetCategoryIds = 0;
			int budgetIds = 0;
			int ownerIds = 0;

			var Finance = new Bogus.DataSets.Finance();
			var Commerce = new Bogus.DataSets.Commerce();
			var Lorem = new Bogus.DataSets.Lorem();
			var Name = new Bogus.DataSets.Name();

			Faker<Owner> ownerFaker = new Faker<Owner>()
			.CustomInstantiator(f => new Owner(
				ownerIds++,
				Name.FirstName(f.PickRandom(f.Person.Gender)),
				Name.LastName(f.PickRandom(f.Person.Gender))));

			Faker<BudgetItem> budgetItemFaker = new Faker<BudgetItem>()
			.CustomInstantiator(f => new BudgetItem(
				budgetItemIds++,
				Commerce.ProductName(),
				Lorem.Sentence(),
				Finance.Amount()));

			Faker<BudgetCategory> budgetCategoryFaker = new Faker<BudgetCategory>()
			.CustomInstantiator(f => new BudgetCategory(
				budgetCategoryIds++,
				Commerce.Categories(1)[0],
				Lorem.Sentence(),
				budgetItemFaker.Generate(10)));

			Faker<Budget> budgetFaker = new Faker<Budget>()
			.CustomInstantiator(f => new Budget(
				budgetIds++,
				Commerce.Categories(1)[0],
				Lorem.Sentence(),
				budgetCategoryFaker.Generate(5), ownerFaker.Generate(1)));
		}
	}
}
