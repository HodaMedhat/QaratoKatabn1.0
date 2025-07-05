namespace Q.VM.ViewModels
{
    public class BorrowingBookVM
    {
        public int Id { get; set; }

        public int? BookId { get; set; }

        public string? EbookLink { get; set; }

        public virtual BooksDetailVM? Book { get; set; }
    }
}
