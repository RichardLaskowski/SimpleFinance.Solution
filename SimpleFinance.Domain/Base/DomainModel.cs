using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFinance.Domain.Base
{
	public class DomainModel
	{
		protected int Id { get; set; }

		public DomainModel(int id)
		{
			Id = id;
		}
	}
}