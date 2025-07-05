namespace Q.VM.ViewModels
{
    public class LkWarnngVM
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public virtual ICollection<WarningVM> Warnings { get; set; } = new List<WarningVM>();
    }
}
