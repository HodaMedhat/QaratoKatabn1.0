using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Q.EF.Models;

[Table("LkBookStatus")]
public partial class LkBookStatus
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [InverseProperty("BookStatusNavigation")]
    public virtual ICollection<UserLibrary> UserLibraries { get; set; } = new List<UserLibrary>();
}
