using System;
using System.Collections.Generic;

namespace MyMvcApp.Models;

public partial class User
{
    public int Id { get; set; }

    public int Roleid { get; set; }

    public string Username { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Profileimage { get; set; }

    public string Address { get; set; } = null!;

    public string Phoneno { get; set; } = null!;

    public bool Isdeleted { get; set; }

    public DateTime Createdat { get; set; }

    public DateTime? Modifiedat { get; set; }

    public string? Createdby { get; set; }

    public string? Modifiedby { get; set; }

    public bool Isactive { get; set; }

    public string Country { get; set; } = null!;

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Zipcode { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
