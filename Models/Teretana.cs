namespace getfitEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teretana")]
    public partial class Teretana
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Sifra { get; set; }

        [Required]
        [StringLength(50)]
        public string Adresa { get; set; }

        public int Kapacitet { get; set; }

        [Required]
        [StringLength(10)]
        public string Telefon { get; set; }

        public virtual SifTeretana SifTeretana { get; set; }
    }
}
