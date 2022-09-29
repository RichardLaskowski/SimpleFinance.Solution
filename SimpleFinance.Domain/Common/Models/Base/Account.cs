using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Common.Models.Base
{
	public abstract class Account : DomainModel
	{
		private List<Owner> _owners;
		private protected int AccountId => _id;
		internal string AccountNumber { get; set; }
		internal string Name { get; set; }
		internal string Description { get; set; }
		internal ReadOnlyCollection<Owner> Owners { get; private set; }

		internal Account(int accountId, string accountNumber, string name, string description, List<Owner> owners) : base(accountId)
		{
			AccountNumber = accountNumber;
			Name = name;
			Description = description;
			_owners = owners;
			Owners = new ReadOnlyCollection<Owner>(_owners);
		}
	}
}