using System;
using System.Collections.Generic;

namespace PizzaShopDB.DataModels;

public partial class Rolepermission
{
    public int Id { get; set; }

    public int Roleid { get; set; }

    public int Permissionid { get; set; }

    public bool Canview { get; set; }

    public bool Canedit { get; set; }

    public bool Candelete { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string? Createdby { get; set; }

    public string? Modifiedby { get; set; }

    public virtual Permission Permission { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
