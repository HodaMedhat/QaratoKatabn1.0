using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q.VM.ViewModels
{
    public class WarningVM
    {
        
        public int Id { get; set; }

        public int MasterId { get; set; }

        public int WarningType { get; set; }

        public string? WarningDetails { get; set; }

        public virtual BookMasterVM Master { get; set; } = null!;

        public virtual LkWarnngVM WarningTypeNavigation { get; set; } = null!;
    }
}
