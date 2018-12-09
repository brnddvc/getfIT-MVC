namespace getfitEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trening")]
    public partial class Trening
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        public int Tip { get; set; }

        public int Kapacitet { get; set; }

        [Column(TypeName = "date")]
        public DateTime Datum { get; set; }

        public TimeSpan Vrijeme { get; set; }

        public int Trajanje { get; set; }

        public int? Popunjenost { get; set; }

        public int Trener { get; set; }

        public int Teretana { get; set; }

        public virtual SifTeretana SifTeretana { get; set; }

        public virtual SifTrener SifTrener { get; set; }

        public virtual SifTrening SifTrening { get; set; }
    }
}
