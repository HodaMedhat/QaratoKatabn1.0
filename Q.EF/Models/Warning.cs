using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Q.EF.Models;

[Table("Warning")]
public partial class Warning
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int MasterId { get; set; }

    public int WarningType { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? WarningDetails { get; set; }

    [ForeignKey("MasterId")]
    [InverseProperty("Warnings")]
    public virtual BookMaster Master { get; set; } = null!;

    [ForeignKey("WarningType")]
    [InverseProperty("Warnings")]
    public virtual LkWarnng WarningTypeNavigation { get; set; } = null!;
}
