using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace iTallyBook.Models.ViewModels
{
    public class IndexViewModel
    {

        [DisplayName("類型")]
        public string Type { get; set; }

        [DisplayName("日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DataDate { get; set; }

        [DisplayName("金額")]
        [DisplayFormat(DataFormatString = "{0:#,##0.##}")]
        public decimal Amount { get; set; }
    }
}