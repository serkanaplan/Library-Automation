using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class islemmodel
    {
        public string id { get; set; }
        [Required]
        public string kullanici_id { get; set; }
        [Required]
        public string kitap_id { get; set; }
        public DateTime islem_tarihi { get; set; }
        public DateTime sistem_iade_tarihi { get; set; }
        public DateTime kullanici_iade_tarihi { get; set; }
        public bool islem_durumu { get; set; }
    }
}
