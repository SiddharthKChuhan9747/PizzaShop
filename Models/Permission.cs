using System;
using System.Collections.Generic;

namespace MyMvcApp.Models;

public partial class Permission
{
    public int Id { get; set; }

    public string Permissionname { get; set; } = null!;

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string? Createdby { get; set; }

    public string? Modifiedby { get; set; }

    public virtual ICollection<Rolepermission> Rolepermissions { get; set; } = new List<Rolepermission>();
}
