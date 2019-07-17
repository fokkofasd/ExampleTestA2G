using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderSystems.Models;

namespace OrderSystems.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Order()
        {
            return View();
        }

        public ActionResult addOrder()
        {
            OrderModel ord = new OrderModel();
            ord.addOrder();
            return View();
        }

        public ActionResult updateOrder()
        {
            OrderModel ord = new OrderModel();
            ord.updateOrder();
            return View();
        }

        public ActionResult getOrder()
        {
            OrderModel ord = new OrderModel();
            var orderList = new List<Order>();
            orderList = ord.getOrder();
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}