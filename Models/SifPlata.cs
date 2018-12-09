namespace getfitEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SifPlata")]
    public partial class SifPlata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SifPlata()
        {
            ZaposlenikUplataIsplata = new HashSet<ZaposlenikUplataIsplata>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Sifra { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        public int Plata { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZaposlenikUplataIsplata> ZaposlenikUplataIsplata { get; set; }
    }
}
