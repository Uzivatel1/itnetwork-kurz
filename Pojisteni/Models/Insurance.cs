using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Pojisteni.Models
{
    public class Insurance
    {
        public int Id { get; set; }

        [Display(Name = "Pojištění")]
        public string Typ { get; set; } = "";

        [Display(Name = "Částka")]
        public int Castka { get; set; }

        [Display(Name = "Předmět pojištění")]
        public string Predmet { get; set; } = "";

        [DataType(DataType.Date)]
        [Display(Name = "Platnost od")]
        public DateTime PlatnostOd { get; set; }

        [DataType(DataType.Date)]        
        [Display(Name = "Platnost do")]
        public DateTime PlatnostDo { get; set; }

        [Display(Name = "Pojištěnec")]
        public User? User { get; set; }

        [Display(Name = "Přidat pojištění k")]
        public int UserId { get; set; }
    }
}
