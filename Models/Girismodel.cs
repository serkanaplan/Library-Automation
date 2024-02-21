using System.ComponentModel.DataAnnotations;

namespace Model
{//kullanıcı girişi için gerekli olan proprty ve kontroller
    public class Girismodel
    {
        [Required,EmailAddress]
        public string mail { get; set; }
        [Required,MinLength(6),MaxLength(50)]
        public string sifre { get; set; }
       
    }
}
