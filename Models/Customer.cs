using System;
using System.Collections.Generic;

namespace MyMvcApp.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phoneno { get; set; } = null!;

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Waitingtoken> Waitingtokens { get; set; } = new List<Waitingtoken>();
}
