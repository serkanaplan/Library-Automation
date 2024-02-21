using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Baglantilar
{
    public class Validasyon
    {
        public static IEnumerable<ValidationResult> Validasyonmetod(object obj)
        {
            var validasyon = new List<ValidationResult>();
            var icerik = new ValidationContext(obj, null, null);
            if (Validator.TryValidateObject(obj, icerik, validasyon, true))
            {
                return null;
            }
            else
            {
                return validasyon;
            }
        }

        public static bool validasyondogrula(object obj)
        {
            var eror = Validasyonmetod(obj);
            if (eror != null)
            {
                foreach (var item in eror)
                {
                    MessageBox.Show(item.ErrorMessage, "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
