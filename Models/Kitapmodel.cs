using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Kitapmodel
    {
        public int id { get; set; }

        [Required,MinLength(13),MaxLength(13)]
        public string isbn { get; set; }

        [Required, MaxLength(50)]
        public string kitap_adi { get; set; }

        [Required]
        public string yazar_id { get; set; }

        [Required,MaxLength(4),MinLength(4)]
        public string baski_yili { get; set; }
        [Required]
        public string yayinevi_id { get; set; }
       
        [Required]
        public string kategori_id { get; set; }
        public string kitap_durumu { get; set; }
        [Required]
        public string stok { get; set; }
        public string ekleyen_mail { get; set; }

    }
}
