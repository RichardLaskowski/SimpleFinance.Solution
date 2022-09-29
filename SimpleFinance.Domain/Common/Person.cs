using SimpleFinance.Domain.Base;

namespace SimpleFinance.Domain
{
	public abstract class Person : DomainModel
	{
		protected int PersonId { get => Id; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get => $"{FirstName} {LastName}"; }

		public Person(
			int personId,
			string firstName,
			string lastName) : base(personId)
		{
			FirstName = firstName;
			LastName = lastName;
		}
	}
}