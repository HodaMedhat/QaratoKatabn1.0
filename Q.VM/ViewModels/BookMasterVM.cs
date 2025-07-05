namespace Q.VM.ViewModels
{
    public class BookMasterVM
    {
        public int Id { get; set; }

        public string BookName { get; set; } = null!;

        public string? AuthorName { get; set; }

        public virtual ICollection<BooksDetailVM> BooksDetails { get; set; } = new List<BooksDetailVM>();

        public virtual ICollection<WarningVM> Warnings { get; set; } = new List<WarningVM>();
    }
}
