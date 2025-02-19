using System;
using System.Collections.Generic;

namespace PizzaShopDB.DataModels;

public partial class Tableordermapping
{
    public int Id { get; set; }

    public int Orderid { get; set; }

    public int Tableid { get; set; }

    public int Noofperson { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public bool Isdeleted { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Table Table { get; set; } = null!;
}
