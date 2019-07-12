using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iTallyBook.Models.ViewModels;

namespace iTallyBook.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            List<IndexViewModel> dataList = GetAccountingDataList();
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

        /// <summary>
        /// 取得收支紀錄清單
        /// </summary>
        /// <returns></returns>
        private List<IndexViewModel> GetAccountingDataList()
        {
            var dataList = new List<IndexViewModel>();
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < 100; i++)
            {
                IndexViewModel item = new IndexViewModel();
                item.Amount = ran.Next(10, 20000);
                item.Type = item.Amount % 2 == 0 ? "支出" : "收入";
                item.DataDate = DateTime.Now.AddDays(ran.Next(-20, 1));
                dataList.Add(item);
            }

            return dataList.OrderByDescending(x => x.DataDate).ToList();
        }
    }
}