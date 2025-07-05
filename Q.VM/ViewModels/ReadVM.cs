namespace Q.VM.ViewModels
{
    public class ReadVM
    {
        public int Id { get; set; }

        public DateOnly? DateStarted { get; set; }

        public DateOnly? DateEnd { get; set; }

        public string? Reviews { get; set; }

        public int? Rate { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }


        public virtual BooksDetailVM Book { get; set; } = null!;


        public virtual UserVM User { get; set; } = null!;
    }
}
