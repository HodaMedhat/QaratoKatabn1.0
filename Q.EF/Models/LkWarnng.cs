using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Q.EF.Models;

[Table("LkWarnng")]
public partial class LkWarnng
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [InverseProperty("WarningTypeNavigation")]
    public virtual ICollection<Warning> Warnings { get; set; } = new List<Warning>();
}
