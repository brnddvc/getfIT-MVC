namespace getfitEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KorisnikTrening")]
    public partial class KorisnikTrening
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Korisnik { get; set; }

        public int Trening { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual SifTrening SifTrening { get; set; }
    }
}
