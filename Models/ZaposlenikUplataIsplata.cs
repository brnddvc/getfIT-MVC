namespace getfitEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZaposlenikUplataIsplata")]
    public partial class ZaposlenikUplataIsplata
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Uplata { get; set; }

        public int Zaposlenik { get; set; }

        public int Plata { get; set; }

        public virtual SifPlata SifPlata { get; set; }

        public virtual UplataIsplata UplataIsplata { get; set; }

        public virtual Zaposlenik Zaposlenik1 { get; set; }
    }
}
