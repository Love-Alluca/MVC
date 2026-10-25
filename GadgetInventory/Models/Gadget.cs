using System.ComponentModel.DataAnnotations;

namespace GadgetInventory.Models
{
    public class Gadget
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Brand is required.")]
        public required string Brand { get; set; }

        [Required(ErrorMessage = "Model is required.")]
        [Display(Name = "Model Name")]
        public required string Model { get; set; }

        [Range(1, 5000, ErrorMessage = "Price must be between $1 and $5000.")]
        public decimal Price { get; set; }
    }
}