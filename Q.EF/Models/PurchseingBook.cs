using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
