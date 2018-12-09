namespace getfitEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZaposlenikUser")]
    public partial class ZaposlenikUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Zaposlenik { get; set; }

        public int User { get; set; }

        public int Uloga { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Role Role { get; set; }

        public virtual User User1 { get; set; }
    }
}
