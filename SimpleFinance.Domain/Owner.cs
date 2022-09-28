using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain
{
	public class Owner : Person
	{
		public int OwnerId { get => PersonId; }
		public Owner(
			int ownerId,
			string firstName,
			string lastName) : base(ownerId, firstName, lastName)
		{
		}
	}
}