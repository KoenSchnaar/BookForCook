using BookForCook.Models;

namespace BookForCook.Repositories
{
    public interface IIngriediëntenRepository
    {
        void AddIngrediënt(ReceptModel recept);
        public SearchByIngrediëntModel GetAllIngrediënts();
    }
}