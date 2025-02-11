using System;
using System.Collections.Generic;

namespace MyMvcApp.Models;

public partial class Ordertaxmapping
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int TaxId { get; set; }

    public decimal Taxvalue { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime Createdat { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? Modifiedat { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Taxesandfee Tax { get; set; } = null!;
}
