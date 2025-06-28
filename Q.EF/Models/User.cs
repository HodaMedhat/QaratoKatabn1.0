using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Q.EF.Models;

public partial class User
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(30)]
    public string? Name { get; set; }

    [StringLength(30)]
    public string UserName { get; set; } = null!;

    [StringLength(30)]
    public string Password { get; set; } = null!;

    [StringLength(30)]
    public string Email { get; set; } = null!;

    [StringLength(1)]
    public string? Librarian { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Read> Reads { get; set; } = new List<Read>();

    [InverseProperty("User")]
    public virtual ICollection<UserLibrary> UserLibraries { get; set; } = new List<UserLibrary>();
}
