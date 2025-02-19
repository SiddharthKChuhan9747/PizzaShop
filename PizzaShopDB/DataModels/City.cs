using System;
using System.Collections.Generic;

namespace PizzaShopDB.DataModels;

public partial class City
{
    public int Id { get; set; }

    public int Stateid { get; set; }

    public string Name { get; set; } = null!;

    public string? Pincode { get; set; }

    public DateTime Createdat { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Updatedat { get; set; }

    public string? Updatesdby { get; set; }

    public virtual State State { get; set; } = null!;
}
