using OrderManagementSystem.Core.Data;
using OrderManagementSystem.Core.Repository;
using OrderManagementSystem.Helper;
using OrderManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderManagementSystem.Controllers
{
    public class ParamedOrderController : Controller
    {
        private IParamedRepository _paramedRepository = new ParamedRepository();
        // GET: ParamedOrder
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var list = new List<Paramed>();
            var paramedOrderList = _paramedRepository.GetAllParamedOrder();
            foreach (var item in paramedOrderList)
            {
                list.Add(new ParamedMapper().MaptoParamedModel(item));
            }
            return PartialView("_GetAll",list);
        }

        public ActionResult AddaService()
        {
            return View();
        }

        public ActionResult SaveService(ParamedOrder order)
        {
            var returnVal = _paramedRepository.AddOrder(order);
            return Json(returnVal, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CancelOrder()
        {
            return View();
        }

        public ActionResult Cancel(int orderId)
        {
            var returnVal = _paramedRepository.CancelOrder(orderId);
            return Json(returnVal, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SendToBilling()
        {
            return View();
        }

        public ActionResult SendForBilling(ParamedOrder order)
        {
            var returnVal = true;

            // To Do this might call seperate Billing system and return success/fail message

            return Json(returnVal, JsonRequestBehavior.AllowGet);
        }
    }
}