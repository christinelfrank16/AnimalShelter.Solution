using System.ComponentModel.DataAnnotations;
namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        [Display(Name = "Admittance Date")]
        public string AdmittanceDate { get; set; }
        public string Breed { get; set; }
    }
}