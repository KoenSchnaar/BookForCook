using System;
using System.Collections.Generic;

namespace KookboekDB
{
    public partial class Ingrediënten
    {
        public Ingrediënten()
        {
            GerechtIngrediënts = new HashSet<GerechtIngrediënt>();
        }

        public int IngrediëntId { get; set; }
        public string Ingrediënt { get; set; }

        public virtual ICollection<GerechtIngrediënt> GerechtIngrediënts { get; set; }
    }
}