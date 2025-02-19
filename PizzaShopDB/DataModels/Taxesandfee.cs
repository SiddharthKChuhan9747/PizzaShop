using System;
using System.Collections.Generic;

namespace PizzaShopDB.DataModels;

public partial class Taxesandfee
{
    public int Id { get; set; }

    public string Taxname { get; set; } = null!;

    public decimal? Flatamount { get; set; }

    public decimal? Percentage { get; set; }

    public bool Isactive { get; set; }

    public bool Isdefault { get; set; }

    public decimal Taxvalue { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public bool Isdeleted { get; set; }

    public virtual ICollection<Ordertaxmapping> Ordertaxmappings { get; set; } = new List<Ordertaxmapping>();
}
