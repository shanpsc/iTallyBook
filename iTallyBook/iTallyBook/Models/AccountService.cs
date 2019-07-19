using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iTallyBook.Models.ViewModels;

namespace iTallyBook.Models
{
    public class AccountService
    {
        private readonly SkillTreeHomeworkEntities _db;

        public AccountService()
        {
            _db = new SkillTreeHomeworkEntities();
        }

        /// <summary>
        /// 取得收支紀錄清單
        /// </summary>
        /// <returns></returns>
        public List<IndexViewModel> GetAccountBookList()
        {
            var dataList = (from i in _db.AccountBook
                            select new IndexViewModel()
                            {
                                Amount = i.Amounttt,
                                DataDate = i.Dateee,
                                Type = i.Categoryyy == 1 ?  "支出" : "收入"
                            }).ToList();
            return dataList;
        }

    }
}