using System;
using System.Collections.Generic;

namespace MyMvcApp.Models;

public partial class Mappingmenuitemwithmodifier
{
    public int Id { get; set; }

    public int Menuitemid { get; set; }

    public int Modifiergroupid { get; set; }

    public int Minselectionrequired { get; set; }

    public int Maxselectionallowed { get; set; }

    public bool? Isdeleted { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public virtual Menuitem Menuitem { get; set; } = null!;

    public virtual Modifiergroup Modifiergroup { get; set; } = null!;
}
