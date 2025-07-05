namespace Q.VM.ViewModels
{
    public class LkFormatVM
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public virtual ICollection<BooksDetailVM> BooksDetails { get; set; } = new List<BooksDetailVM>();
    }
}
