using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace BeerShop.ViewModels
{
    public class BeerCreateVM
    {

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
        public int Alcohol { get; set; }
    }
}
