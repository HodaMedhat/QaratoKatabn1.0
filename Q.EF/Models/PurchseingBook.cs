using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Q.EF.Models;

[Table("PurchseingBook")]
public partial class PurchseingBook
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int? BookId { get; set; }

    [ForeignKey("BookId")]
    [InverseProperty("PurchseingBooks")]
    public virtual BooksDetail? Book { get; set; }
}
