namespace Emlakci2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER1.EV_SAHIBI")]
    public partial class EV_SAHIBI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EV_SAHIBI()
        {
            EV = new HashSet<EV>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short EVSAHIBIID { get; set; }

        [StringLength(15)]
        public string AD { get; set; }

        [StringLength(25)]
        public string SOYAD { get; set; }

        [StringLength(11)]
        public string CEPTEL { get; set; }

        [StringLength(11)]
        public string ISYERITEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EV> EV { get; set; }
    }
}
