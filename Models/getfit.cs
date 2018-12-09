namespace getfitEF.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class getfit : DbContext
    {
        public getfit()
            : base("name=getfit")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<KorisnikTrening> KorisnikTrening { get; set; }
        public virtual DbSet<KorisnikUplataIsplata> KorisnikUplataIsplata { get; set; }
        public virtual DbSet<KorisnikUser> KorisnikUser { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<SifDobnaSkupina> SifDobnaSkupina { get; set; }
        public virtual DbSet<SifGodina> SifGodina { get; set; }
        public virtual DbSet<SifMjesec> SifMjesec { get; set; }
        public virtual DbSet<SifPaket> SifPaket { get; set; }
        public virtual DbSet<SifPlata> SifPlata { get; set; }
        public virtual DbSet<SifSpol> SifSpol { get; set; }
        public virtual DbSet<SifTeretana> SifTeretana { get; set; }
        public virtual DbSet<SifTrener> SifTrener { get; set; }
        public virtual DbSet<SifTrening> SifTrening { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Teretana> Teretana { get; set; }
        public virtual DbSet<Trening> Trening { get; set; }
        public virtual DbSet<UplataIsplata> UplataIsplata { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Zaposlenik> Zaposlenik { get; set; }
        public virtual DbSet<ZaposlenikUplataIsplata> ZaposlenikUplataIsplata { get; set; }
        public virtual DbSet<ZaposlenikUser> ZaposlenikUser { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.KorisnikTrening)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.KorisnikUser)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.KorisnikUplataIsplata)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.ZaposlenikUser)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Zaposlenik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.KorisnikUser)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.Uloga)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role1)
                .HasForeignKey(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.ZaposlenikUser)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.Uloga)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SifDobnaSkupina>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<SifGodina>()
                .HasMany(e => e.UplataIsplata)
                .WithRequired(e => e.SifGodina)
                .HasForeignKey(e => e.Sifra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SifMjesec>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<SifMjesec>()
                .HasMany(e => e.UplataIsplata)
                .WithRequired(e => e.SifMjesec)
                .HasForeignKey(e => e.Sifra1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SifPaket>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<SifPaket>()
                .HasMany(e => e.KorisnikUplataIsplata)
                .WithRequired(e => e.SifPaket)
                .HasForeignKey(e => e.Paket)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SifPlata>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<SifPlata>()
                .HasMany(e => e.ZaposlenikUplataIsplata)
                .WithRequired(e => e.SifPlata)
                .HasForeignKey(e => e.Plata)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SifSpol>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<SifSpol>()
                .HasMany(e => e.Korisnik)
                .WithRequired(e => e.SifSpol)
                .HasForeignKey(e => e.Sifra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SifSpol>()
                .HasMany(e => e.Zaposlenik)
                .WithRequired(e => e.SifSpol)
                .HasForeignKey(e => e.Sifra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SifTeretana>()
                .HasMany(e => e.Teretana)
                .WithRequired(e => e.SifTeretana)
                .HasForeignKey(e => e.Sifra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SifTeretana>()
                .HasMany(e => e.Trening)
                .WithRequired(e => e.SifTeretana)
                .HasForeignKey(e => e.Teretana)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SifTrener>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<SifTrener>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<SifTrener>()
                .HasMany(e => e.Trening)
                .WithRequired(e => e.SifTrener)
                .HasForeignKey(e => e.Trener)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SifTrening>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<SifTrening>()
                .HasMany(e => e.KorisnikTrening)
                .WithRequired(e => e.SifTrening)
                .HasForeignKey(e => e.Trening)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SifTrening>()
                .HasMany(e => e.Trening)
                .WithRequired(e => e.SifTrening)
                .HasForeignKey(e => e.Tip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teretana>()
                .Property(e => e.Adresa)
                .IsUnicode(false);

            modelBuilder.Entity<Teretana>()
                .Property(e => e.Telefon)
                .IsFixedLength();

            modelBuilder.Entity<Trening>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<UplataIsplata>()
                .HasMany(e => e.KorisnikUplataIsplata)
                .WithRequired(e => e.UplataIsplata)
                .HasForeignKey(e => e.Uplata)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UplataIsplata>()
                .HasMany(e => e.ZaposlenikUplataIsplata)
                .WithRequired(e => e.UplataIsplata)
                .HasForeignKey(e => e.Uplata)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.KorisnikUser)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ZaposlenikUser)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zaposlenik>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Zaposlenik>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Zaposlenik>()
                .Property(e => e.BrojLicneKarte)
                .IsUnicode(false);

            modelBuilder.Entity<Zaposlenik>()
                .Property(e => e.AdresaPrebivalista)
                .IsUnicode(false);

            modelBuilder.Entity<Zaposlenik>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Zaposlenik>()
                .HasMany(e => e.ZaposlenikUplataIsplata)
                .WithRequired(e => e.Zaposlenik1)
                .HasForeignKey(e => e.Zaposlenik)
                .WillCascadeOnDelete(false);
        }
    }
}
