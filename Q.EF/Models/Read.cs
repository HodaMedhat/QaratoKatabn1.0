using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Q.EF.Models;

public partial class Read
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public DateOnly? DateStarted { get; set; }

    public DateOnly? DateEnd { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Reviews { get; set; }

    public int? Rate { get; set; }

    public int UserId { get; set; }

    public int BookId { get; set; }

    [ForeignKey("BookId")]
    [InverseProperty("Reads")]
    public virtual BooksDetail Book { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Reads")]
    public virtual User User { get; set; } = null!;
}
