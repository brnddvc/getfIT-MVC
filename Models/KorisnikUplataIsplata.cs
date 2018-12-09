namespace getfitEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KorisnikUplataIsplata")]
    public partial class KorisnikUplataIsplata
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Uplata { get; set; }

        public int Korisnik { get; set; }

        public int Paket { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual SifPaket SifPaket { get; set; }

        public virtual UplataIsplata UplataIsplata { get; set; }
    }
}
