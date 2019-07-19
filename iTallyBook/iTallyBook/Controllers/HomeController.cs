using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iTallyBook.Models;
using iTallyBook.Models.ViewModels;

namespace iTallyBook.Controllers
{
    public class HomeController : Controller
    {
        private AccountService _accountSvc = new AccountService();

        /// <summary>
        /// 首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            List<IndexViewModel> dataList = _accountSvc.GetAccountBookList();
            return View(dataList);
        }

        /// <summary>
        /// 關於
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// 連絡方式
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}