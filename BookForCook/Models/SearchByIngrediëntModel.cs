using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookForCook.Models
{
    public class SearchByIngrediëntModel
    {
        public List<SelectListItem> Ingrediënten { get; set; }
        public string Ingrediënt1 { get; set; }
        public string Ingrediënt2 { get; set; }
        public string Ingrediënt3 { get; set; }
    }
}
