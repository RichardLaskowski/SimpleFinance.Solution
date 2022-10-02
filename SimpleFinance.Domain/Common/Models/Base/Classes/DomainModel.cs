using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;
using CommunityToolkit.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SimpleFinance.Domain.Common.Models.Base;

/// <summary>
/// 
/// </summary>
public abstract class DomainModel
{
    private protected int _id { get; init; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    protected DateTime LastChangeDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    protected string LastChangeUser { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    protected DomainModel(int id = 0)
    {
        GuardDomainModel(id);

        _id = id;
    }

    private void GuardDomainModel(int id)
    {
        GuardInt(id, nameof(id));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="name"></param>
    protected void GuardString(string value, string name)
    {
        Guard.IsNotNullOrEmpty(value, name);
        Guard.IsNotWhiteSpace(value, name);
        Guard.IsOfType<string>(value, name);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="name"></param>
    protected void GuardInt(int value, string name)
    {
        Guard.IsNotNull<int>(value, name);
        Guard.IsGreaterThanOrEqualTo<int>(value, 0, name);
        Guard.IsOfType<int>(value, name);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="values"></param>
    /// <param name="name"></param>
    /// <typeparam name="T"></typeparam>
    protected void GuardCollection<T>(ICollection<T> values, string name)
    {
        Guard.HasSizeGreaterThanOrEqualTo<T>(values, 0, name);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="name"></param>
    protected void GuardDecimal(decimal value, string name)
    {
        Guard.IsNotNull<decimal>(value);
        Guard.IsGreaterThanOrEqualTo<decimal>(value, 0, name);
        Guard.IsOfType<decimal>(value, name);
    }
}