using System.ComponentModel.DataAnnotations;

namespace CommissionOuverturePlis.Classes
{
    public class FournisseurModel
    {
        // Étape 1
        [Required(ErrorMessage = "Le nom est requis.")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "La nature juridique est requise.")]
        public string NatureJuridique { get; set; }

        [Required(ErrorMessage = "L'adresse est requise.")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Le téléphone est requis.")]
        public string Telephone { get; set; }

        [EmailAddress(ErrorMessage = "Adresse mail invalide.")]
        public string Email { get; set; }

        // Étape 2
        [Required(ErrorMessage = "Le Registre Commerce est requis.")]
        public string RegistreCommerce { get; set; }
        [Required(ErrorMessage = "Le NIF est requis.")]
        public string NIF { get; set; }
        [Required(ErrorMessage = "Le NIS est requis.")]
        public string NIS { get; set; }
        [Required(ErrorMessage = "Le Article Imposition est requis.")]
        public string ArticleImposition { get; set; }
        [Required(ErrorMessage = "Le RIB est requis.")]
        public string RIB { get; set; }
        [Required(ErrorMessage = "Le Agence Bancaire est requis.")]
        public string Agence { get; set; }
    }
}
