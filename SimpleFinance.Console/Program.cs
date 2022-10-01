using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Bogus;
using Bogus.DataSets;
using CommunityToolkit.Diagnostics;
using SimpleFinance.Domain.Budgets.Models;
using SimpleFinance.Domain.Common.Models.Base;

namespace SimpleFinance.ConsoleUI;

internal class Program
{
	private static Faker<Budget> budgetFaker;
	private static Faker<BudgetCategory> budgetCategoryFaker;
	private static Faker<BudgetItem> budgetItemFaker;
	private static Faker<BudgetOwner> budgetOwnerFaker;
	private static Faker<Owner> ownerFaker;
	private static int budgetItemIds = 0;
	private static int budgetCategoryIds = 0;
	private static int budgetIds = 0;
	private static int ownerIds = 0;
	private static Finance Finance;
	private static Commerce Commerce;
	private static Name Name;
	private static Lorem Lorem;
	private static List<Budget> Budgets;

	static void Main(string[] args)
	{
		//Budgets = Seed();
		string response = string.Empty;


		Console.WriteLine("Menu");
		Console.WriteLine("1. Create budget");
		Console.WriteLine("2. List budgets");
		Console.WriteLine("3. Edit budget");
		Console.WriteLine("4. Delete budget");

		response = Console.ReadLine();

		switch (response)
		{
			case "1":
				CreateNewBudget();
				break;
			case "2":
				ListAllBudgets();
				break;
			case "3":
				SelectABudgetToEdit();
				break;
			case "4":
				SelectABudgetToDelete();
				break;
			default:
				break;
		}
	}

	private static Budget CreateNewBudget()
	{
		Budget newBudget = budgetFaker.Generate();
		return newBudget;
	}
	private static void ListAllBudgets()
	{
		foreach (Budget budget in Budgets)
		{
			System.Console.WriteLine($"{budget.BudgetId}: {budget.Name}");
		}
	}
	private static void SelectABudgetToEdit()
	{
		throw new NotImplementedException();
	}
	private static void SelectABudgetToDelete()
	{
		throw new NotImplementedException();
	}
	//private static List<Budget> Seed()
	//{
	//	Finance = new Bogus.DataSets.Finance();
	//	Commerce = new Bogus.DataSets.Commerce();
	//	Lorem = new Bogus.DataSets.Lorem();
	//	Name = new Bogus.DataSets.Name();

	//	ownerFaker = new Faker<Owner>()
	//	.CustomInstantiator(f => new Owner(
	//		ownerIds++,
	//		Name.FirstName(f.PickRandom(f.Person.Gender)),
	//		Name.LastName(f.PickRandom(f.Person.Gender))));

	//	budgetOwnerFaker = new Faker<BudgetOwner>()
	//	.CustomInstantiator(factoryMethod: f => new BudgetOwner(
	//		ownerIds++,
	//		Name.FirstName(f.PickRandom(f.Person.Gender)),
	//		Name.LastName(f.PickRandom(f.Person.Gender))));

	//	budgetItemFaker = new Faker<BudgetItem>()
	//	.CustomInstantiator(f => new BudgetItem(
	//		budgetItemIds++,
	//		Commerce.ProductName(),
	//		Lorem.Sentence(),
	//		Finance.Amount()));

	//	budgetCategoryFaker = new Faker<BudgetCategory>()
	//	.CustomInstantiator(f => new BudgetCategory(
	//		budgetCategoryIds++,
	//		Commerce.Categories(1).First(),
	//		Lorem.Sentence(),
	//		budgetItemFaker.Generate(10)));

	//	budgetFaker = new Faker<Budget>()
	//	.CustomInstantiator(f => new Budget(
	//		budgetIds++,
	//		Commerce.Categories(1)[0],
	//		Lorem.Sentence(),
	//		budgetCategoryFaker.Generate(5),
	//		budgetOwnerFaker.Generate(1)));

	//	List<Budget> budgets = budgetFaker.Generate(5);

	//	return budgets;
	//}
}
