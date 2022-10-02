using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CommunityToolkit.Diagnostics;

namespace SimpleFinance.Domain.Common.Models.Base;

/// <summary>
/// 
/// </summary>
public abstract class Account : DomainModel
{
    private readonly List<Owner> _owners;
    private protected int AccountId => _id;
    internal string AccountNumber { get; set; }
    internal string Name { get; set; }
    internal string Description { get; set; }
    internal ReadOnlyCollection<Owner> Owners { get; private set; }

    internal Account(int accountId, string accountNumber, string name, string description, List<Owner> owners) : base(accountId)
    {
        GuardAccount(accountNumber, name, description, owners);

        AccountNumber = accountNumber;
        Name = name;
        Description = description;
        _owners = owners;
        Owners = new ReadOnlyCollection<Owner>(_owners);
    }

    private protected void GuardAccount(string accountNumber, string name, string description, List<Owner> owners)
    {
        GuardString(accountNumber, nameof(accountNumber));
        GuardString(name, nameof(name));
        GuardString(description, nameof(description));
        GuardCollection<Owner>(owners, nameof(owners));
    }
}