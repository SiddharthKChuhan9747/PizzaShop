using System;
using System.Collections.Generic;

namespace MyMvcApp.Models;

public partial class Waitingtoken
{
    public int Id { get; set; }

    public int Custid { get; set; }

    public int? Tableid { get; set; }

    public int? Sectionid { get; set; }

    public int Noofperson { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string Createdby { get; set; } = null!;

    public string? Modifiedby { get; set; }

    public bool Isdeleted { get; set; }

    public bool Isassigned { get; set; }

    public virtual Customer Cust { get; set; } = null!;

    public virtual Section? Section { get; set; }

    public virtual Table? Table { get; set; }
}
