using System;
using System.Collections.Generic;

namespace MyMvcApp.Models;

public partial class State
{
    public int Id { get; set; }

    public int Countryid { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Createdat { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Updatedat { get; set; }

    public string? Updatesdby { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country Country { get; set; } = null!;
}
