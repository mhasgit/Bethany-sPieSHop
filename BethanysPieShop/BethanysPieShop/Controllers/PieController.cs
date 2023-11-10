using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _piesRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository piesRepository, ICategoryRepository categoryRepository)
        {
            _piesRepository = piesRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List()
        {
            // Old way
            //ViewBag.CurrentCategory = "Cheese cakes";
            //return View(_piesRepository.AllPies);

            PieListViewModel piesListViewModel = new PieListViewModel(_piesRepository.AllPies, "Cheesy cakes");

            return View(piesListViewModel);
        }
    }
}