namespace getfitEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SifDobnaSkupina")]
    public partial class SifDobnaSkupina
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Sifra { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        public int GodinePocetak { get; set; }

        public int GodineKraj { get; set; }
    }
}
