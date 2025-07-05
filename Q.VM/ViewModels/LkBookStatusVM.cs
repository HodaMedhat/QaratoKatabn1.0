namespace Q.VM.ViewModels
{
    public class LkBookStatusVM
    {
        public int Id { get; set; }

        public string? Name { get; set; }


        public virtual ICollection<UserLibraryVM> UserLibraries { get; set; } = new List<UserLibraryVM>();
    }
}
