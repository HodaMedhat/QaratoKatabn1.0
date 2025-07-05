using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Q.EF.Models;

public partial class BooksDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? BookCover { get; set; }

    public int? Author { get; set; }

    public int? Format { get; set; }

    public int? Length { get; set; }

    public int? Pubilsher { get; set; }

    [Column("ISDN")]
    public int? Isdn { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? AoT { get; set; }

    public int? Translator { get; set; }

    public int? MasterId { get; set; }

    [ForeignKey("Author")]
    [InverseProperty("BooksDetails")]
    public virtual LkAuthor? AuthorNavigation { get; set; }

    [InverseProperty("Book")]
    public virtual ICollection<BorrowingBook> BorrowingBooks { get; set; } = new List<BorrowingBook>();

    [ForeignKey("Format")]
    [InverseProperty("BooksDetails")]
    public virtual LkFormat? FormatNavigation { get; set; }

    [ForeignKey("MasterId")]
    [InverseProperty("BooksDetails")]
    public virtual BookMaster? Master { get; set; }

    [ForeignKey("Pubilsher")]
    [InverseProperty("BooksDetails")]
    public virtual LkPubilsher? PubilsherNavigation { get; set; }

    [InverseProperty("Book")]
    public virtual ICollection<PurchseingBook> PurchseingBooks { get; set; } = new List<PurchseingBook>();

    [InverseProperty("Book")]
    public virtual ICollection<Read> Reads { get; set; } = new List<Read>();

    [ForeignKey("Translator")]
    [InverseProperty("BooksDetails")]
    public virtual LkTrasnslator? TranslatorNavigation { get; set; }

    [InverseProperty("Book")]
    public virtual ICollection<UserLibrary> UserLibraries { get; set; } = new List<UserLibrary>();
}
