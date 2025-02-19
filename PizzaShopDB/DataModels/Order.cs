using System;
using System.Collections.Generic;

namespace PizzaShopDB.DataModels;

public partial class Order
{
    public int Id { get; set; }

    public int Custid { get; set; }

    public decimal Subtotal { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Discount { get; set; }

    public decimal Totalamount { get; set; }

    public decimal? Paidamount { get; set; }

    public int Orderstatus { get; set; }

    public string? Notes { get; set; }

    public int Orderno { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public bool IsSgstselected { get; set; }

    public virtual Customer Cust { get; set; } = null!;

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<Ordereditem> Ordereditems { get; set; } = new List<Ordereditem>();

    public virtual ICollection<Ordertaxmapping> Ordertaxmappings { get; set; } = new List<Ordertaxmapping>();

    public virtual ICollection<Tableordermapping> Tableordermappings { get; set; } = new List<Tableordermapping>();
}
