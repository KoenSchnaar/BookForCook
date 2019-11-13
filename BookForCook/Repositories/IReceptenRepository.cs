using BookForCook.Models;
using System.Collections.Generic;

namespace BookForCook.Repositories
{
    public interface IReceptenRepository
    {
        ReceptModel AddGerecht(ReceptModel recept);
        public List<ReceptModel> GetAllRecepten();
        public void DeleteRecept(int gerechtID);
        public ReceptModel GetRecept(int gerechtID);
        public List<ReceptModel> GetSearchedRecepten(SearchByIngrediëntModel searchModel);
    }
}