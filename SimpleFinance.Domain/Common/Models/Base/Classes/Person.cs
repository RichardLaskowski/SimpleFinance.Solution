using System;
using System.Xml.Schema;
using CommunityToolkit.Diagnostics;

namespace SimpleFinance.Domain.Common.Models.Base
{
	public abstract class Person : DomainModel
	{
		private protected int PersonId { get => _id; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get => $"{FirstName} {LastName}"; }

		protected Person(
			int personId,
			string firstName,
			string lastName) : base(personId)
		{
			GuardPerson(firstName, lastName);

			FirstName = firstName;
			LastName = lastName;
		}

		private protected void GuardPerson(string firstName, string lastName)
		{
			try
			{
				GuardString(firstName, nameof(firstName));
				GuardString(lastName, nameof(lastName));
			}
			catch (ArgumentNullException innerException)
			{
				throw new ArgumentNullException(innerException.Message, innerException);
			}
			catch (ArgumentException innerException)
			{
				throw new ArgumentException(innerException.Message, innerException);
			}
		}
	}
}