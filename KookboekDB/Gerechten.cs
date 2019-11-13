using System;
using System.Collections.Generic;

namespace KookboekDB
{
    public partial class Gerechten
    {
        public Gerechten()
        {
            GerechtIngrediënts = new HashSet<GerechtIngrediënt>();
        }

        public int GerechtId { get; set; }
        public string Gerecht { get; set; }
        public bool Vegetarisch { get; set; }
        public int Bereidingstijd { get; set; }
        public int AantalIngrediënten { get; set; }
        public string Foto { get; set; }
        public string Bereidingswijze { get; set; }

        public virtual ICollection<GerechtIngrediënt> GerechtIngrediënts { get; set; }
    }
}