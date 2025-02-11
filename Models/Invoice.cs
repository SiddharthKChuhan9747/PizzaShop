using System;
using System.Collections.Generic;

namespace MyMvcApp.Models;

public partial class Invoice
{
    public int Id { get; set; }

    public int Orderid { get; set; }

    public int? Modifierid { get; set; }

    public int Quantityofmodifier { get; set; }

    public decimal Rateofmodifier { get; set; }

    public decimal Totalamount { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public virtual Modifier? Modifier { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
