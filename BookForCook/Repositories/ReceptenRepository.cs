using BookForCook.Models;
using BookForCook.Converteer;
using KookboekDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookForCook.Repositories
{
    public class ReceptenRepository : IReceptenRepository
    {
        private readonly KookboekContext context;
        ConvertRecept converteerder = new ConvertRecept();


        public ReceptenRepository(KookboekContext context)
        {
            this.context = context;
        }

        public List<ReceptModel> GetAllRecepten()
        {
            return context.Gerechtens.ToList().Select(g => converteerder.Converteer(g))
                .ToList();
        }

        public ReceptModel GetRecept(int gerechtID)
        {
            var entity = context.Gerechtens.Single(g => g.GerechtId == gerechtID);
            var recept = converteerder.Converteer(entity);
            var ingredienten = context.GerechtIngrediënts.Where(g => g.GerechtId == gerechtID).ToList();
            var IngrediëntenList = new List<GerechtIngrediëntenModel>();

            foreach (var ingr in ingredienten)
            {
                var ingrediëntEntity = context.Ingrediëntens.Single(i => i.IngrediëntId == ingr.IngrediëntId);
                var newIngr = new GerechtIngrediëntenModel
                {
                    Ingrediënt = ingrediëntEntity.Ingrediënt,
                    Hoeveelheid = ingr.Hoeveelheid,
                    Eenheid = ingr.Eenheid
                };
                IngrediëntenList.Add(newIngr);
            }
            recept.Ingrediënten = IngrediëntenList;
        return recept;
        }

        public ReceptModel AddGerecht(ReceptModel recept)
        {
            var newGerecht = new Gerechten
            {
                Gerecht = recept.Gerecht,
                Bereidingstijd = recept.Bereidingstijd,
                Bereidingswijze = recept.Beschrijving,
                Vegetarisch = recept.Vegetarisch
            };
            context.Gerechtens.Add(newGerecht);
            context.SaveChanges();
            recept.GerechtId = newGerecht.GerechtId;
            return recept;
        }

        public void DeleteRecept(int gerechtID)
        {
            var entity = context.Gerechtens.Single(g => g.GerechtId == gerechtID);
            context.Gerechtens.Remove(entity);
            context.SaveChanges();
        }

        public List<ReceptModel> GetSearchedRecepten(SearchByIngrediëntModel searchModel)
        {
            var ingredienten = new[] { Convert.ToInt32(searchModel.Ingrediënt1), Convert.ToInt32(searchModel.Ingrediënt2), Convert.ToInt32(searchModel.Ingrediënt3) };
            //var gerechten = context.Gerechtens.
            //    Where(g => g.GerechtIngrediënts.Any(gi => ingredienten.Contains(gi.IngrediëntId))).ToList();

            var gerechten = context.Gerechtens.Include(g => g.GerechtIngrediënts);
            var result = new List<ReceptModel>();
            foreach (var gerecht in gerechten)
            {
                var ing = gerecht.GerechtIngrediënts.Select(gi => gi.IngrediëntId);
                if (ing.Contains(ingredienten[0]) && ing.Contains(ingredienten[1]) && ing.Contains(ingredienten[2]))
                {
                    result.Add(new ReceptModel
                    {
                        GerechtId = gerecht.GerechtId,
                        Gerecht = gerecht.Gerecht,
                        Vegetarisch = gerecht.Vegetarisch,
                        Bereidingstijd = gerecht.Bereidingstijd,
                        AantalIngrediënten = gerecht.AantalIngrediënten,
                        Foto = gerecht.Foto,
                        Beschrijving = gerecht.Bereidingswijze
                    });
                }
            }
            return result;
        }
    }
}
