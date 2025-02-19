using System;
using System.Collections.Generic;

namespace PizzaShopDB.DataModels;

public partial class Feedback
{
    public int Id { get; set; }

    public int Orderid { get; set; }

    public int Food { get; set; }

    public int Service { get; set; }

    public int Ambience { get; set; }

    public int Avgrating { get; set; }

    public string? Comment { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public virtual Order Order { get; set; } = null!;
}
