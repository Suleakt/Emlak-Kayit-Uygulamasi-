namespace Emlakci2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER1.EMLAKCI")]
    public partial class EMLAKCI
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short EMLAKCIID { get; set; }

        [Required]
        [StringLength(30)]
        public string ADSOYAD { get; set; }

        [StringLength(40)]
        public string EMAIL { get; set; }

        [StringLength(11)]
        public string TELEFON { get; set; }

        [StringLength(5)]
        public string SIFRE { get; set; }

        [StringLength(1)]
        public string YETKI_CREATE { get; set; }

        [StringLength(1)]
        public string YETKI_EDIT { get; set; }

        [StringLength(1)]
        public string YETKI_DELETE { get; set; }
    }
}
