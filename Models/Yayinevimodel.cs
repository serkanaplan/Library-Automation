using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Yayinevimodel
    {
        public int id { get; set; }
        [Required, MaxLength(50)]

        public string yayinevi_adi { get; set; }
    }
}
