using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kookboek.Controllers
{
    public class ReceptController : Controller
    {
        private readonly IReceptenApiService rServ;

        public ReceptController(IReceptenApiService RServ)
        {
            rServ = RServ;
        }

        public async Task<IActionResult> GetRecepten()
        {
            var model = await rServ.GetAllRecepten();
            return View(model);
        }

        //public IActionResult AddRecept()
        //{
        //    var ing = GIRepo.AddIngrediënten();
        //    var recept = new ReceptModel();
        //    recept.Ingrediënten = ing;
        //    return View(recept);
        //}

        //[HttpPost]
        //public IActionResult AddRecept(ReceptModel recept)
        //{
        //    var newRecept = ReceptenRepo.AddGerecht(recept);
        //    Irepo.AddIngrediënt(newRecept);
        //    GIRepo.AddRecept(newRecept);
        //    return RedirectToAction("GetRecepten");
        //}

        //[Authorize(Policy = "DeleteAccesPolicy")]
        //public IActionResult DeleteRecept(int gerechtID)
        //{
        //    GIRepo.DeleteRecept(gerechtID);
        //    ReceptenRepo.DeleteRecept(gerechtID);
        //    return RedirectToAction("GetRecepten");
        //}

        //public IActionResult GoToRecept(int gerechtID)
        //{
        //    return View(ReceptenRepo.GetRecept(gerechtID));
        //}

        //public IActionResult SearchByIngrediënt()
        //{
        //    return View(Irepo.GetAllIngrediënts());
        //}

        //[HttpPost]
        //public IActionResult SearchByIngrediënt(SearchByIngrediëntModel searchModel)
        //{
        //    var filteredRecepten = ReceptenRepo.GetSearchedRecepten(searchModel);
        //    return View("GetRecepten", filteredRecepten);
        //}
    }
}
