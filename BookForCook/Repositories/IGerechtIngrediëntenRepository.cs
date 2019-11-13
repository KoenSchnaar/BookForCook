using BookForCook.Models;
using System.Collections.Generic;

namespace BookForCook.Repositories
{
    public interface IGerechtIngrediëntenRepository
    {
        List<GerechtIngrediëntenModel> AddIngrediënten();
        public void AddRecept(ReceptModel recept);
        public void DeleteRecept(int gerechtID);
    }
}