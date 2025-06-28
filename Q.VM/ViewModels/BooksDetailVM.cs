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
    public class BooksDetailVM
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? BookCover { get; set; }

        public int? Author { get; set; }

        public int? Format { get; set; }

        public int? Length { get; set; }

        public int? Pubilsher { get; set; }

      
        public int? Isdn { get; set; }

        public string? AoT { get; set; }

        public int? Translator { get; set; }

        public int? MasterId { get; set; }

        public virtual LkAuthorVM? AuthorNavigation { get; set; }

        public virtual ICollection<BorrowingBookVM> BorrowingBooks { get; set; } = new List<BorrowingBookVM>();

        public virtual LkFormatVM? FormatNavigation { get; set; }

        public virtual BookMasterVM? Master { get; set; }

        public virtual LkPubilsherVM? PubilsherNavigation { get; set; }


        public virtual ICollection<PurchseingBookVM> PurchseingBooks { get; set; } = new List<PurchseingBookVM>();


        public virtual ICollection<ReadVM> Reads { get; set; } = new List<ReadVM>();

        public virtual LkTrasnslatorVM? TranslatorNavigation { get; set; }


        public virtual ICollection<UserLibraryVM> UserLibraries { get; set; } = new List<UserLibraryVM>();
    }
}
