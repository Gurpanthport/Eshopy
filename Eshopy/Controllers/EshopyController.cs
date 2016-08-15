using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eshopy.Models;
using System.Diagnostics;

namespace Eshopy.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantContext storeDB = new RestaurantContext();

        // GET: Restaurant
        public ActionResult Index()
        {
            List <FoodTypeModels>FoodType = storeDB.FoodTypes.ToList();
            return View(FoodType);
        }

        public ActionResult Browse(string FoodType)
        {
            //Debug.WriteLine(type);
            FoodTypeModels foodTypesModel = storeDB.FoodTypes.Include("FoodItems").Single(g => g.Name == FoodType);
            return View(foodTypesModel);
        }
        public ActionResult Details(int id = 1)
        {
            FoodItemModels FoodItem = storeDB.FoodItems.Find(id);
            return View(FoodItem);
        }
    }
}