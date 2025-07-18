﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Q.EF.Models;

public partial class LkAuthor
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [InverseProperty("AuthorNavigation")]
    public virtual ICollection<BooksDetail> BooksDetails { get; set; } = new List<BooksDetail>();
}
