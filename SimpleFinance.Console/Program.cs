using System;
using System.Collections.Generic;
using Bogus;
using SimpleFinance.Domain;

namespace SimpleFinance.ConsoleUI
{
	internal class Program
	{
		private const int Count = 100;

		static void Main(string[] args)
		{
			int ownerIds = 1;

			Faker<Owner> ownerFaker = new Faker<Owner>()
			.CustomInstantiator(f => new Owner(ownerIds++, f.Name.FirstName(f.PickRandom(f.Person.Gender)), f.Name.LastName()));


			List<Owner> owners = ownerFaker.Generate(Count);

			foreach (Owner owner in owners)
			{
				System.Console.WriteLine($"{owner.OwnerId}: {owner.FullName}");

			}
		}
	}
}