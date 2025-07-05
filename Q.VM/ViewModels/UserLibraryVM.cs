namespace Q.VM.ViewModels
{
    public class UserLibraryVM
    {

        public int Id { get; set; }

        public int? BookStatus { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }

        public virtual BooksDetailVM Book { get; set; } = null!;

        public virtual LkBookStatusVM? BookStatusNavigation { get; set; }
        public virtual UserVM User { get; set; } = null!;
    }
}
