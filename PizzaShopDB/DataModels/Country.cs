using System;
using System.Collections.Generic;

namespace PizzaShopDB.DataModels;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Createdat { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Updatedat { get; set; }

    public string? Updatesdby { get; set; }

    public virtual ICollection<State> States { get; set; } = new List<State>();
}
