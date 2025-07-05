using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



namespace Q.EF.Models;

public partial class QARATOKATABNContext : DbContext
{
    public QARATOKATABNContext()
    {
    }

    public QARATOKATABNContext(DbContextOptions<QARATOKATABNContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookMaster> BookMasters { get; set; }

    public virtual DbSet<BooksDetail> BooksDetails { get; set; }

    public virtual DbSet<BorrowingBook> BorrowingBooks { get; set; }

    public virtual DbSet<LkAuthor> LkAuthors { get; set; }

    public virtual DbSet<LkBookStatus> LkBookStatuses { get; set; }

    public virtual DbSet<LkFormat> LkFormats { get; set; }

    public virtual DbSet<LkPubilsher> LkPubilshers { get; set; }

    public virtual DbSet<LkTrasnslator> LkTrasnslators { get; set; }

    public virtual DbSet<LkWarnng> LkWarnngs { get; set; }

    public virtual DbSet<PurchseingBook> PurchseingBooks { get; set; }

    public virtual DbSet<Read> Reads { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserLibrary> UserLibraries { get; set; }

    public virtual DbSet<Warning> Warnings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {


        try
        {
            string c = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DBConnection"));
        }
        catch
        {
            //ignore
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookMaster>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AuthorName).IsFixedLength();
            entity.Property(e => e.BookName).IsFixedLength();
        });

        modelBuilder.Entity<BooksDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BooksDet__3214EC27D42EF685");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.AuthorNavigation).WithMany(p => p.BooksDetails).HasConstraintName("FK_BooksDetails_LkAuthors");

            entity.HasOne(d => d.FormatNavigation).WithMany(p => p.BooksDetails).HasConstraintName("FK_BooksDetails_LkFormat");

            entity.HasOne(d => d.Master).WithMany(p => p.BooksDetails).HasConstraintName("FK_BooksDetails_BookMaster");

            entity.HasOne(d => d.PubilsherNavigation).WithMany(p => p.BooksDetails).HasConstraintName("FK_BooksDetails_LkPubilshers");

            entity.HasOne(d => d.TranslatorNavigation).WithMany(p => p.BooksDetails).HasConstraintName("FK_BooksDetails_LkTrasnslators");
        });

        modelBuilder.Entity<BorrowingBook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Borrowin__3214EC278D4DA19D");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Book).WithMany(p => p.BorrowingBooks).HasConstraintName("FK_BorrowingBook_BooksDetails");
        });

        modelBuilder.Entity<LkAuthor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LkAuthor__3214EC276A0E7036");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<LkBookStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LkBookSt__3214EC27717BA4AE");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<LkFormat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LkFormat__3214EC27C3A1AD96");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<LkPubilsher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LkPubils__3214EC2776CCC491");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<LkTrasnslator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LkTrasns__3214EC27B0421F10");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<LkWarnng>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LkWarnng__3214EC27CDE3B637");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PurchseingBook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Purchsei__3214EC276374D3EB");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Book).WithMany(p => p.PurchseingBooks).HasConstraintName("FK_PurchseingBook_BooksDetails");
        });

        modelBuilder.Entity<Read>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reads__3214EC2704748A1C");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Book).WithMany(p => p.Reads)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reads_BooksDetails");

            entity.HasOne(d => d.User).WithMany(p => p.Reads)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reads_Users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email).IsFixedLength();
            entity.Property(e => e.Librarian).IsFixedLength();
            entity.Property(e => e.Name).IsFixedLength();
            entity.Property(e => e.Password).IsFixedLength();
            entity.Property(e => e.UserName).IsFixedLength();
        });

        modelBuilder.Entity<UserLibrary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserLibr__3214EC27382BFDE9");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Book).WithMany(p => p.UserLibraries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserLibrary_BooksDetails");

            entity.HasOne(d => d.BookStatusNavigation).WithMany(p => p.UserLibraries).HasConstraintName("FK_UserLibrary_LkBookStatus");

            entity.HasOne(d => d.User).WithMany(p => p.UserLibraries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserLibrary_Users");
        });

        modelBuilder.Entity<Warning>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Warning__3214EC278B71246B");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Master).WithMany(p => p.Warnings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Warning_BookMaster");

            entity.HasOne(d => d.WarningTypeNavigation).WithMany(p => p.Warnings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Warning_LkWarnng");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
