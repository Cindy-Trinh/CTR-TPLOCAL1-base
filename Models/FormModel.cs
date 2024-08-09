using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace TPLOCAL1.Models
{
    public class FormModel
    {


        [Required(ErrorMessage = "Le nom est requis.")]
        public string nom {  get; set; }

        [Required(ErrorMessage = "Le prénom est requis.")]
        public string prenom {  get; set; }

        [RegularExpression("Homme|Femme|Autre", ErrorMessage = "Vous devez sélectionner un sexe.")]
        public string sexe { get; set; }

        [Required(ErrorMessage = "L'adresse est requise.")]
        public string adresse { get; set; }

        [Required(ErrorMessage = "Le code postal est requis.")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Le code postal doit contenir exactement 5 chiffres.")]
        public string codepost { get; set; }

        [Required(ErrorMessage = "La ville est requise.")]
        public string ville { get; set; }

        [Required(ErrorMessage = "L'adresse mail est requise.")]
        [RegularExpression(@"^([\w]+)@([\w]+)\.([\w]+)$", ErrorMessage = "L'adresse mail doit être sous la forme xxx@xxx.xxx'.")]
        public string mail { get; set; }

        [Required(ErrorMessage = "Vous devez sélectionner la date de début de formation.")]
        [DataType(DataType.Date)]
        public DateTime? datedeb {  get; set; }

        [RegularExpression("Cobol|Object|Dual Skills", ErrorMessage = "Vous devez sélectionner la formation suivie.")]
        public string formation { get; set; }

        [Required(ErrorMessage = "L'avis sur la formation Cobol est requise.")]
        public string cobol { get; set; }
    
        [Required(ErrorMessage = "L'avis sur la formation C# est requise.")]
        public string csharp { get; set; }


        



    }

    
}
