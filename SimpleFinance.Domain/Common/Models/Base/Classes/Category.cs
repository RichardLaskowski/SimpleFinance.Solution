using System;

namespace SimpleFinance.Domain.Common.Models.Base;

/// <summary>
/// 
/// </summary>
public abstract class Category : DomainModel
{
    private protected int CategoryId => _id;

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    protected internal string Name { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    protected internal string Description { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="categoryId"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <returns></returns>
    protected Category(int categoryId, string name, string description) : base(categoryId)
    {
        GuardCategory(name, description);

        Name = name;
        Description = description;
    }

    private protected void GuardCategory(string name, string description)
    {
        GuardString(name, nameof(name));
        GuardString(description, nameof(description));
    }
}