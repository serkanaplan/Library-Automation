using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Kategorimodel
    {
        public int id { get; set; }
        [Required,MaxLength(50)]
        public string kategori_adi { get; set; }

    }
}
