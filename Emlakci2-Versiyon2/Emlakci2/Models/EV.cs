namespace Emlakci2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER1.EV")]
    public partial class EV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EV()
        {
            TESLIM_EDILEN_EV = new HashSet<TESLIM_EDILEN_EV>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short EVID { get; set; }

        [Required]
        [StringLength(20)]
        public string IL { get; set; }

        [Required]
        [StringLength(20)]
        public string ILCE { get; set; }

        [Required]
        [StringLength(30)]
        public string MAHALLE { get; set; }

        [StringLength(10)]
        public string SATISDURUM { get; set; }

        [Required]
        [StringLength(12)]
        public string TUR { get; set; }

        public short? ILANNO { get; set; }

        public int? FIYAT { get; set; }

        [StringLength(10)]
        public string ODASAY { get; set; }

        [StringLength(12)]
        public string METREKARE { get; set; }

        public short? EVSAHIBIID { get; set; }

        //public short? EVDETAYID { get; set; }

        [Required]
        [StringLength(1)]
        public string SATILDIMI { get; set; }

        //public virtual EV_DETAY EV_DETAY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TESLIM_EDILEN_EV> TESLIM_EDILEN_EV { get; set; }

        public virtual EV_SAHIBI EV_SAHIBI { get; set; }

        [StringLength(40)]
        public string IMAGE { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public EV_DETAY()
        //{
        //    EV = new HashSet<EV>();
        //}

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public short EVDETAYID { get; set; }

        public byte KATNO { get; set; }

        [StringLength(150)]
        public string ADRES { get; set; }

        public DateTime? EVYAPIMTARIHI { get; set; }

        [StringLength(1)]
        public string ESYADURUM { get; set; }

        [StringLength(1)]
        public string OGRENCIBEKAR { get; set; }

        [StringLength(4)]
        public string AIDAT { get; set; }

        [StringLength(5)]
        public string DEPOZITO { get; set; }

        [StringLength(1)]
        public string BALKON { get; set; }

        [StringLength(2)]
        public string BANYOSAY { get; set; }

        [StringLength(1)]
        public string SITEMI { get; set; }

        [StringLength(1)]
        public string OTOPARK { get; set; }

        [StringLength(15)]
        public string YAKITTIPI { get; set; }

        [StringLength(15)]
        public string ISINMATIPI { get; set; }

        [StringLength(5)]
        public string FIYATTUR { get; set; }

        [StringLength(150)]
        public string ACIKLAMA { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<EV> EV { get; set; }

    }
}
