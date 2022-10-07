using CommunityToolkit.Diagnostics;
using SimpleFinance.Domain.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.ConsoleApp.Dialogs;

public class BudgetCategoryCreationDialog
{
	private string _name;
	private string _nameResponse;
	private string _description;
	private string _descriptionResponse;
	private decimal _allottedAmount;
	private string _allottedAmountResponse;
	private Month _month;
	private string _monthResponse;

	public void Prompt()
	{
		Console.Clear();

		PromptForName();
		PromptForDescription();
		PromptForAllottedAmount();
		PromptForMonth();
	}

	private void PromptForName()
	{
		System.Console.WriteLine("Enter a name for the category.");
		_nameResponse = Console.ReadLine();

		try
		{
			ValidateNameResponse();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
			PromptForName();
		}
	}
	private void PromptForDescription()
	{
		System.Console.WriteLine("Enter a description for the category.");
		_descriptionResponse = Console.ReadLine();

		try
		{
			ValidateDescriptionResponse();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
			PromptForDescription();
		}
	}
	private void PromptForAllottedAmount()
	{
		System.Console.WriteLine("Enter the categories allotedAmount.");
		_allottedAmountResponse = Console.ReadLine();

		try
		{
			ValidateAllottedAmountResponse();
		}
		catch (ArgumentException e)
		{
			Console.WriteLine(e.Message);
			PromptForAllottedAmount();
		}
	}
	private void PromptForMonth()
	{
		System.Console.WriteLine("Enter the numerical digit of the month that this category is for.");
		_monthResponse = Console.ReadLine();

		try
		{
			ValidateMonthResponse();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
			PromptForMonth();
		}
	}

	private void ValidateNameResponse()
	{
		Guard.IsNotNullOrEmpty(_nameResponse);
		Guard.IsNotWhiteSpace(_nameResponse);
		_name = _nameResponse.Trim();
	}
	private void ValidateDescriptionResponse()
	{
		Guard.IsNotNullOrEmpty(_descriptionResponse);
		Guard.IsNotWhiteSpace(_descriptionResponse);
		_description = _descriptionResponse.Trim();
	}
	private void ValidateAllottedAmountResponse()
	{
		if(!Decimal.TryParse(_allottedAmountResponse, out _allottedAmount))
		{
			ThrowHelper.ThrowArgumentException<decimal>(_allottedAmountResponse);
		}
	}
	private void ValidateMonthResponse() 
	{ 
		if (!Enum.TryParse(_monthResponse, out _month))
		{
			ThrowHelper.ThrowArgumentException<int>(_monthResponse);
		}
	}
}
