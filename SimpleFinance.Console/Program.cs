using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using SimpleFinance.Domain;
using SimpleFinance.Domain.Budgeting;

namespace SimpleFinance.ConsoleUI
{
	internal class Program
	{
		private const int Count = 10;

		static void Main(string[] args)
		{
			int ownerIds = 0;
			int budgetItemIds = 0;
			int budgetCategoryIds = 0;
			int budgetIds = 0;


			var Finance = new Bogus.DataSets.Finance();
			var Commerce = new Bogus.DataSets.Commerce();
			var Lorem = new Bogus.DataSets.Lorem();


			Faker<BudgetItem> budgetItemFaker = new Faker<BudgetItem>()
			.CustomInstantiator(f => new BudgetItem(budgetItemIds++, Commerce.ProductName(), Lorem.Sentence(), Finance.Amount()));

			Faker<BudgetCategory> budgetCategoryFaker = new Faker<BudgetCategory>()
			.CustomInstantiator(f => new BudgetCategory(budgetCategoryIds++, Commerce.Categories(1)[0], Lorem.Sentence(), budgetItemFaker.Generate(10)));

			Faker<Budget> budgetFaker = new Faker<Budget>()
			.CustomInstantiator(f => new Budget(budgetIds++, Commerce.Categories(1)[0], Lorem.Sentence(), budgetCategoryFaker.Generate(5)));

			Budget budget = budgetFaker.Generate(1).Single();

			System.Console.WriteLine($"Budget Id: {budget.BudgetId}");
			System.Console.WriteLine($"Budget Name: {budget.Name}");
			System.Console.WriteLine($"Budget Description: {budget.Description}");
			System.Console.WriteLine("");
			System.Console.WriteLine("");

			foreach (BudgetCategory category in budget.Categories)
			{
				System.Console.WriteLine($"Category Id: {category.BudgetCategoryId}");
				System.Console.WriteLine($"Category Name: {category.Name}");
				System.Console.WriteLine($"Category Description: {category.Description}");
				System.Console.WriteLine("");
				System.Console.WriteLine("");

				foreach (BudgetItem item in category.Items)
				{
					System.Console.WriteLine($"Item Id: {item.BudgetItemId}");
					System.Console.WriteLine($"Item Name: {item.Name}");
					System.Console.WriteLine($"Item Description: {item.Description}");
					System.Console.WriteLine($"Item Amount: {item.Amount}");
					System.Console.WriteLine("");
				}

				System.Console.WriteLine("");
				System.Console.WriteLine("");
				System.Console.WriteLine("");
			}
		}
	}
}
