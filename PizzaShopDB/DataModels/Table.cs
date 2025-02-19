using System;
using System.Collections.Generic;

namespace PizzaShopDB.DataModels;

public partial class Table
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Sectionid { get; set; }

    public int Capacity { get; set; }

    public bool Isavailable { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public int? Status { get; set; }

    public bool Isdeleted { get; set; }

    public virtual Section Section { get; set; } = null!;

    public virtual ICollection<Tableordermapping> Tableordermappings { get; set; } = new List<Tableordermapping>();

    public virtual ICollection<Waitingtoken> Waitingtokens { get; set; } = new List<Waitingtoken>();
}
