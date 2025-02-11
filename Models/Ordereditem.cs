using System;
using System.Collections.Generic;

namespace MyMvcApp.Models;

public partial class Ordereditem
{
    public int Id { get; set; }

    public int Orderid { get; set; }

    public int Menuitemid { get; set; }

    public string Name { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal Rate { get; set; }

    public decimal Amount { get; set; }

    public decimal Totalmodifieramount { get; set; }

    public decimal? Tax { get; set; }

    public decimal Totalamount { get; set; }

    public string? Instruction { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public int Orderstatusid { get; set; }

    public bool Isdeleted { get; set; }

    public int? Readyitemquantity { get; set; }

    public virtual Menuitem Menuitem { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;

    public virtual ICollection<Ordereditemmodifiermapping> Ordereditemmodifiermappings { get; set; } = new List<Ordereditemmodifiermapping>();
}
