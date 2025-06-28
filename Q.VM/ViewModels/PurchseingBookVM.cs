using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q.VM.ViewModels
{
    public class PurchseingBookVM
    {
        public int Id { get; set; }

        public int? BookId { get; set; }

        public virtual BooksDetailVM? Book { get; set; }
    }
}
