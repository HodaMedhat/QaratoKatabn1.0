using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Q.EF.Models;

[Table("BookMaster")]
public partial class BookMaster
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(30)]
    public string BookName { get; set; } = null!;

    [StringLength(30)]
    public string? AuthorName { get; set; }

    [InverseProperty("Master")]
    public virtual ICollection<BooksDetail> BooksDetails { get; set; } = new List<BooksDetail>();

    [InverseProperty("Master")]
    public virtual ICollection<Warning> Warnings { get; set; } = new List<Warning>();
}
