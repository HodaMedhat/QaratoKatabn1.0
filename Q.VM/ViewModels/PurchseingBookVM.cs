namespace Q.VM.ViewModels
{
    public class PurchseingBookVM
    {
        public int Id { get; set; }

        public int? BookId { get; set; }

        public virtual BooksDetailVM? Book { get; set; }
    }
}
