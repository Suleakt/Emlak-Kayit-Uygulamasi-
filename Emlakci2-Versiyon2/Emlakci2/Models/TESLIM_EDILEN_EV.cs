namespace Emlakci2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER1.TESLIM_EDILEN_EV")]
    public partial class TESLIM_EDILEN_EV
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TESLIMEDILENID { get; set; }

        public DateTime? TARIH { get; set; }

        [Required]
        [StringLength(1)]
        public string ISLEMTAMAMLANDIMI { get; set; }

        public short? EVID { get; set; }

        public short? MUSTERIID { get; set; }

        public virtual EV EV { get; set; }

        public virtual MUSTERI MUSTERI { get; set; }
    }
}
