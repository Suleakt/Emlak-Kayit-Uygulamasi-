namespace Emlakci2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<EMLAKCI> EMLAKCI { get; set; }
        public virtual DbSet<EV> EV { get; set; }
        public virtual DbSet<EV_SAHIBI> EV_SAHIBI { get; set; }
        public virtual DbSet<MUSTERI> MUSTERI { get; set; }
        public virtual DbSet<TESLIM_EDILEN_EV> TESLIM_EDILEN_EV { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EMLAKCI>()
                .Property(e => e.ADSOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<EMLAKCI>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<EMLAKCI>()
                .Property(e => e.TELEFON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.IL)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.ILCE)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.MAHALLE)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.SATISDURUM)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.TUR)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.ODASAY)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.METREKARE)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.SATILDIMI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .HasMany(e => e.TESLIM_EDILEN_EV)
                .WithOptional(e => e.EV)
                .WillCascadeOnDelete();

            modelBuilder.Entity<EV>()
                .Property(e => e.ADRES)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.ESYADURUM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.OGRENCIBEKAR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.AIDAT)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.DEPOZITO)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.BALKON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.BANYOSAY)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.SITEMI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.OTOPARK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.YAKITTIPI)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.ISINMATIPI)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.FIYATTUR)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.IMAGE)
                .IsUnicode(false);

            modelBuilder.Entity<EV>()
                .Property(e => e.ACIKLAMA)
                .IsUnicode(false);

            //modelBuilder.Entity<EV_DETAY>()
            //    .HasMany(e => e.EV)
            //    .WithOptional(e => e.EV_DETAY)
            //    .WillCascadeOnDelete();

            modelBuilder.Entity<EV_SAHIBI>()
                .Property(e => e.AD)
                .IsUnicode(false);

            modelBuilder.Entity<EV_SAHIBI>()
                .Property(e => e.SOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<EV_SAHIBI>()
                .Property(e => e.CEPTEL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EV_SAHIBI>()
                .Property(e => e.ISYERITEL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EV_SAHIBI>()
                .HasMany(e => e.EV)
                .WithOptional(e => e.EV_SAHIBI)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MUSTERI>()
                .Property(e => e.ADSOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERI>()
                .Property(e => e.TELEFON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERI>()
                .Property(e => e.TUR)
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERI>()
                .Property(e => e.IL)
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERI>()
                .Property(e => e.SATISDURUM)
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERI>()
                .Property(e => e.ESYADURUM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERI>()
                .Property(e => e.OGRENCIBEKAR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERI>()
                .HasMany(e => e.TESLIM_EDILEN_EV)
                .WithOptional(e => e.MUSTERI)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TESLIM_EDILEN_EV>()
                .Property(e => e.ISLEMTAMAMLANDIMI)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
