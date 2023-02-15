using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace BeerShop.ViewModels
{
    public class BeerEditVM
    {
        [Required]
        public int Biernr { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]

        [Display(Name = "Brouwer")]

        public int Brouwernr { get; set; }

        public IEnumerable<SelectListItem>? Breweries { get; set; }


        [Display(Name = "Soort")]
        public int Soortnr { get; set; }
        public IEnumerable<SelectListItem>? Varieties { get; set; }
        [Required]
        public decimal? Alcohol { get; set; }
    }
}
