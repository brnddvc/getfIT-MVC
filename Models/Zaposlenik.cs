namespace getfitEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zaposlenik")]
    public partial class Zaposlenik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zaposlenik()
        {
            ZaposlenikUplataIsplata = new HashSet<ZaposlenikUplataIsplata>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ime { get; set; }

        [Required]
        [StringLength(50)]
        public string Prezime { get; set; }

        [Column(TypeName = "date")]
        public DateTime DatumRodjenja { get; set; }

        public int Sifra { get; set; }

        public int BrojKartice { get; set; }

        [Required]
        [StringLength(50)]
        public string BrojLicneKarte { get; set; }

        [Required]
        [StringLength(50)]
        public string AdresaPrebivalista { get; set; }

        public int Telefon { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public virtual SifSpol SifSpol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZaposlenikUplataIsplata> ZaposlenikUplataIsplata { get; set; }
    }
}
