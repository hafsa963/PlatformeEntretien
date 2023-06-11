using System.ComponentModel.DataAnnotations;
namespace PlatformeEntretien.Models
{
    public class Spaceadmin

    {

        public int id { get; set; }
        public string? Mail { get; set; }
        public string? Nom { get; set; }
        public string? Prénom { get; set; }
        public string? Téléphone { get; set; }

    }
}
