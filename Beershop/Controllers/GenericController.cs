using Beershop.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Beershop.Controllers
{
    public class GenericController : Controller
    {
        public IActionResult Index()
        {
            //DataStore countries = new DataStore();

            //countries.AddOrUpdate(0, "Belgium");
            //countries.AddOrUpdate(1, "US");
            //countries.AddOrUpdate(2, "France");

            //Debug.WriteLine(countries.GetData(2));




            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);


            Debug.WriteLine(cities.GetData(2));
            Debug.WriteLine(empIds.GetData(1));

            return View();
        }
    }
}
