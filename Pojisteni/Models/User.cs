using System.ComponentModel.DataAnnotations;

namespace Pojisteni.Models
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Jméno")]
        public string Jmeno { get; set; } = "";

        [Display(Name = "Příjmení")]
        public string Prijmeni { get; set; } = "";

        public string JmenoPrijmeni
        {
            get
            {
                return Jmeno + " " + Prijmeni;
            }
        }

        [Display(Name = "Ulice a číslo popisné")]
        public string UliceCislo { get; set; } = "";

        public string Obec { get; set; } = "";

        [Display(Name = "PSČ")]
        public int PSC { get; set; }
        public string Email { get; set; } = "";

        public int Telefon { get; set; }
        public ICollection<Insurance>? Insurances { get; set; }
    }
}
