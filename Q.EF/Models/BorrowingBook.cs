using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Q.EF.Models;

[Table("BorrowingBook")]
public partial class BorrowingBook
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int? BookId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? EbookLink { get; set; }

    [ForeignKey("BookId")]
    [InverseProperty("BorrowingBooks")]
    public virtual BooksDetail? Book { get; set; }
}
