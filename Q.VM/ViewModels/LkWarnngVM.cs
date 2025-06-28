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
    public class LkWarnngVM
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public virtual ICollection<WarningVM> Warnings { get; set; } = new List<WarningVM>();
    }
}
