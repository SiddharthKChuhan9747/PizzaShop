using System;
using System.Collections.Generic;

namespace PizzaShopDB.DataModels;

public partial class Ordereditemmodifiermapping
{
    public int Id { get; set; }

    public int Orderitemid { get; set; }

    public int Modifierid { get; set; }

    public int Quantityofmodifier { get; set; }

    public decimal Rateofmodifier { get; set; }

    public decimal Totalamount { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public bool Isdeleted { get; set; }

    public virtual Modifier Modifier { get; set; } = null!;

    public virtual Ordereditem Orderitem { get; set; } = null!;
}
