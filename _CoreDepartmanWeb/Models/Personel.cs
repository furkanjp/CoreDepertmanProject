using System.ComponentModel.DataAnnotations;

namespace _CoreDepartmanWeb.Models
{
    public class Personel
    {
        [Key]
        public int PersId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }

        public Departmanlar departlar { get; set; }
    }
}
