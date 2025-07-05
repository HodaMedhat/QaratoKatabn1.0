using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Q.EF.Models;

[Table("UserLibrary")]
public partial class UserLibrary
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int? BookStatus { get; set; }

    public int UserId { get; set; }

    public int BookId { get; set; }

    [ForeignKey("BookId")]
    [InverseProperty("UserLibraries")]
    public virtual BooksDetail Book { get; set; } = null!;

    [ForeignKey("BookStatus")]
    [InverseProperty("UserLibraries")]
    public virtual LkBookStatus? BookStatusNavigation { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UserLibraries")]
    public virtual User User { get; set; } = null!;
}
