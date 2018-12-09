namespace getfitEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UplataIsplata")]
    public partial class UplataIsplata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UplataIsplata()
        {
            KorisnikUplataIsplata = new HashSet<KorisnikUplataIsplata>();
            ZaposlenikUplataIsplata = new HashSet<ZaposlenikUplataIsplata>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Sifra { get; set; }

        public int Sifra1 { get; set; }

        public int Uplata { get; set; }

        public int Isplata { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KorisnikUplataIsplata> KorisnikUplataIsplata { get; set; }

        public virtual SifGodina SifGodina { get; set; }

        public virtual SifMjesec SifMjesec { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZaposlenikUplataIsplata> ZaposlenikUplataIsplata { get; set; }
    }
}
