using BookForCook.Models;
using KookboekDB;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookForCook.Repositories
{
    public class IngriediëntenRepository : IIngriediëntenRepository
    {
        private readonly KookboekContext context;

        public IngriediëntenRepository(KookboekContext context)
        {
            this.context = context;
        }
        public void AddIngrediënt(ReceptModel recept) 
        {
            foreach (var ingr in recept.Ingrediënten)
            {
                var bestaat = context.Ingrediëntens.Count(i => i.Ingrediënt == ingr.Ingrediënt);
                if (ingr.Ingrediënt != null && bestaat == 0)
                {
                    var newIngrediënt = new Ingrediënten
                    {
                        Ingrediënt = ingr.Ingrediënt
                    };
                    context.Ingrediëntens.Add(newIngrediënt);
                }
            }
            context.SaveChanges();
        }

        public SearchByIngrediëntModel GetAllIngrediënts()
        {
            var IngrEntities = context.Ingrediëntens.Select(i => new SelectListItem { Value = i.IngrediëntId.ToString(), Text = i.Ingrediënt }).ToList();
            var ingrediënten = new SearchByIngrediëntModel
            {
                Ingrediënten = IngrEntities
            };
            return ingrediënten;
        }
    }
}
