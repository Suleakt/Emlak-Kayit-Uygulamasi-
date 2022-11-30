namespace Emlakci2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER1.MUSTERI")]
    public partial class MUSTERI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MUSTERI()
        {
            TESLIM_EDILEN_EV = new HashSet<TESLIM_EDILEN_EV>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MUSTERIID { get; set; }

        [Required]
        [StringLength(30)]
        public string ADSOYAD { get; set; }

        [Required]
        [StringLength(11)]

        public string TELEFON { get; set; }

        public int? MINFIYAT { get; set; }

        public int? MAXFIYAT { get; set; }

        [StringLength(12)]
        public string TUR { get; set; }

        [StringLength(20)]
        public string IL { get; set; }

        [StringLength(10)]
        public string SATISDURUM { get; set; }

        [Required]
        [StringLength(1)]
        public string ESYADURUM { get; set; }

        [Required]
        [StringLength(1)]
        public string OGRENCIBEKAR { get; set; }

        public short? ALINANILANNO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TESLIM_EDILEN_EV> TESLIM_EDILEN_EV { get; set; }
    }
}
