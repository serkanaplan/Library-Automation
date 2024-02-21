using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Kullanicimodel
    {
        public int id { get; set; }

        [Required, MaxLength(50)]
        public string ad { get; set; }

        [Required, MaxLength(50)]
        public string soyad { get; set; }

        [Required,MinLength(11),MaxLength(11)]
        public string tc { get; set; }
       
        [Required, MaxLength(100),EmailAddress]
        public string mail { get; set; }

        [Required, MaxLength(50)]
        public string sifre { get; set; }

        [Required,MinLength(11), MaxLength(11),Phone]
        public string tel { get; set; }

        [MaxLength(200)]
        public string adres { get; set; }

        public string a_kitap_sayisi { get; set; }
        public string borc { get; set; }
        public bool yetki_durumu { get; set; }
        public bool kayit_durumu { get; set; }

    }
}
