using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;
using CommunityToolkit.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SimpleFinance.Domain.Common.Models.Base
{
	public abstract class DomainModel 
	{
		private protected int _id { get; init; }

		protected DomainModel(int id = 0)
		{
			GuardDomainModel(id);

			_id = id;
		}

		private void GuardDomainModel(int id)
		{
			GuardInt(id, nameof(id));
		}

		protected void GuardString(string value, string name)
		{
			Guard.IsNotNullOrEmpty(value, name);
			Guard.IsNotWhiteSpace(value, name);
		}

		protected void GuardInt(int value, string name)
		{
			Guard.IsNotNull<int>(value, name);
			Guard.IsGreaterThanOrEqualTo<int>(value, 0, name);
		}

		protected void GuardCollection<T>(ICollection<T> values, string name)
		{
			Guard.HasSizeGreaterThanOrEqualTo<T>(values, 1, name);
		}

		protected void GuardDecimal(decimal value, string name)
		{
			Guard.IsNotNull<decimal>(value);
			Guard.IsGreaterThanOrEqualTo<decimal>(value, 0, name);
		}
	}
}