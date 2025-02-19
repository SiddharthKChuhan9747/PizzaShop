using System;
using System.Collections.Generic;

namespace PizzaShopDB.DataModels;

public partial class Payment
{
    public int Id { get; set; }

    public int Invoiceid { get; set; }

    public decimal Amount { get; set; }

    public int Paymentmethod { get; set; }

    public int Status { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public virtual Invoice Invoice { get; set; } = null!;
}
