using System;
using System.Collections.Generic;

namespace PizzaShopDB.DataModels;

public partial class Modifiergroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool Isdeleted { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public virtual ICollection<Mappingmenuitemwithmodifier> Mappingmenuitemwithmodifiers { get; set; } = new List<Mappingmenuitemwithmodifier>();

    public virtual ICollection<Modifier> Modifiers { get; set; } = new List<Modifier>();
}
