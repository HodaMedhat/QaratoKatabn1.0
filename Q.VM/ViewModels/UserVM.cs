namespace Q.VM.ViewModels
{
    public class UserVM
    {
        public int Id { get; set; }


        public string? Name { get; set; }


        public string UserName { get; set; } = null!;


        public string Password { get; set; } = null!;


        public string Email { get; set; } = null!;


        public string? Librarian { get; set; }


        public virtual ICollection<ReadVM> Reads { get; set; } = new List<ReadVM>();


        public virtual ICollection<UserLibraryVM> UserLibraries { get; set; } = new List<UserLibraryVM>();
    }
}
