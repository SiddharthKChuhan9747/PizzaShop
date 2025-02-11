using System;
using System.Collections.Generic;

namespace MyMvcApp.Models;

public partial class Menuitem
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int Itemtype { get; set; }

    public decimal Rate { get; set; }

    public decimal Quantity { get; set; }

    public int Unit { get; set; }

    public int Categoryid { get; set; }

    public decimal? Taxpercentage { get; set; }

    public bool Isdefaulttax { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public bool? IsAvailable { get; set; }

    public string? Image { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsFavorite { get; set; }

    public string? Shortcode { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Mappingmenuitemwithmodifier> Mappingmenuitemwithmodifiers { get; set; } = new List<Mappingmenuitemwithmodifier>();

    public virtual ICollection<Ordereditem> Ordereditems { get; set; } = new List<Ordereditem>();
}
