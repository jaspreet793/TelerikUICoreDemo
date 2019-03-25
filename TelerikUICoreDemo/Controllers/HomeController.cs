using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TelerikUICoreDemo.DL;
using TelerikUICoreDemo.Models;

namespace TelerikUICoreDemo.Controllers
{
    public partial class HomeController : Controller
    {
        CustomerDataLogic _customerData = new CustomerDataLogic();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Customers_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetCustomers().ToDataSourceResult(request));
        }

        private IEnumerable<CallListDto> GetCustomers()
        {
            return _customerData.GetAll();
        }



        [HttpPost]
        public ActionResult Customers_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<CallListDto> dealers)
        {
            if (dealers != null && ModelState.IsValid)
            {
                foreach (var dealer in dealers)
                {
                    if (dealer.Name.ToLower() == "jay")
                    {
                        ModelState.AddModelError("Name", "Name is not Valid");
                        return Json(dealers.ToDataSourceResult(request, ModelState));
                    }
                    _customerData.Put(dealer);
                }
            }

            return Json(dealers.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Customers_Create([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<CallListDto> dealers)
        {
            var results = new List<CallListDto>();
            if (dealers != null && ModelState.IsValid)
            {
                foreach (var dealer in dealers)
                {
                    results.Add(dealer);
                    if (dealer.Name.ToLower() == "jay")
                    {
                        ModelState.AddModelError("Name", "Name is not Valid");
                        return Json(results.ToDataSourceResult(request, ModelState));
                    }
                    _customerData.Post(dealer);
                    
                }
            }

            return Json(results.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Customers_Destroy([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<CallListDto> dealers)
        {
            foreach (var dealer in dealers)
            {
                _customerData.Delete(dealer.Id);
            }

            return Json(dealers.ToDataSourceResult(request, ModelState));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
