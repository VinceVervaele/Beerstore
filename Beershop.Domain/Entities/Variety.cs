using System;
using System.Collections.Generic;

namespace BeerStore.Models.Entities
{
    public partial class Variety
    {
        public Variety()
        {
            Beers = new HashSet<Beer>();
        }

        public int Soortnr { get; set; }
        public string Soortnaam { get; set; } = null!;

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
