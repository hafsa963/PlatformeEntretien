using System.ComponentModel.DataAnnotations;

namespace PlatformeEntretien.Models
{
    public class Candidat
    {



        /*(Nom, Prénom, Mail, Téléphone, Niveau d’étude, Nombre d’années d’expérience,
Dernier employeur)*/
        public int id { get; set; }

        public string? Dernier_employeur { get; set; }
        public string? Mail { get; set; }
        public string? Niveau_détude { get; set; }
        public string? Nom { get; set; }
        public string? Nombre_dannées_dexpérience { get; set; }
        public string? Prénom { get; set; }
        public string? Téléphone { get; set; }

    }
}
