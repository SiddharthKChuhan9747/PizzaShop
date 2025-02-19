using System;
using System.Collections.Generic;

namespace PizzaShopDB.DataModels;

public partial class Role
{
    public int Id { get; set; }

    public string Rolename { get; set; } = null!;

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string? Createdby { get; set; }

    public string? Modifiedby { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Rolepermission> Rolepermissions { get; set; } = new List<Rolepermission>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
