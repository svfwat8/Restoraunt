using Restoraunt.BusinessLogic.BL;
using Restoraunt.BusinessLogic.Interfaces;
using Restoraunt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoraunt.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProduct _product;
        public CatalogController()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _product = bl.GetProductBL();
        }

        public ActionResult Orders()
        {
            ViewBag.ActivePage = "Orders";

            var products = _product.GetAll();

            var model = products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Title = p.Title,
                ImageUrl = p.ImageUrl,
                Description = p.Description,
                Price = p.Price,
                Quantity = p.Quantity
            }).ToList();

            return View(model);
        }
        public ActionResult OrdersDetail(int id)
        {
            var product = _product.GetProductById(id);
            if (product == null)
                return HttpNotFound();

            var model = new ProductViewModel
            {
                Id = product.Id,
                Title = product.Title,
                ImageUrl = product.ImageUrl,
                Description = product.Description,
                Price = product.Price,
                Quantity = product.Quantity
            };
            return View(model);
        }

        public ActionResult Menu()
        {
            ViewBag.ActivePage = "Menu";
            var products = _product.GetAll()
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    ImageUrl = p.ImageUrl,
                    Description = p.Description,
                    Price = p.Price,
                    Quantity = p.Quantity
                }).ToList();
            return View(products);
        }

        public ActionResult CustomerDetail(int id)
        {
            var product = _product.GetProductById(id);
            if (product == null)
                return HttpNotFound();
            return View(product);
        }
    }
}