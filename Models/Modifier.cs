using System;
using System.Collections.Generic;

namespace MyMvcApp.Models;

public partial class Modifier
{
    public int Id { get; set; }

    public int Modifiergroupid { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Rate { get; set; }

    public decimal Quantity { get; set; }

    public int Unitid { get; set; }

    public bool Isdeleted { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual Modifiergroup Modifiergroup { get; set; } = null!;

    public virtual ICollection<Ordereditemmodifiermapping> Ordereditemmodifiermappings { get; set; } = new List<Ordereditemmodifiermapping>();

    public virtual Unit Unit { get; set; } = null!;
}
