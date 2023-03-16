using System.ComponentModel.DataAnnotations;

namespace _CoreDepartmanWeb.Models
{
    public class Departmanlar
    {
        [Key]
        public int Id { get; set; }
        public string DepartmanAd { get; set; }    
        //bir departman birden  fazla personel içerebilir bunu liste ile gösterdik.
        public List<Personel> Personeller { get; set; }
    }
}
