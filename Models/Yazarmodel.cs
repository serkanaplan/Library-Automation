using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Yazarmodel
    {
        public string id { get; set; }
        [Required,MaxLength(50)]
        public string ad_soyad { get; set; }
    }
}
