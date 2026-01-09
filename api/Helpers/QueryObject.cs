using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Helpers
{
    // 查詢與分頁用的參數物件
    public class QueryObject
    {
        // 依股票代號過濾
        public string? Symbol { get; set; } = null;
        // 依公司名稱過濾
        public string? CompanyName { get; set; } = null;
        // 排序欄位名稱
        public string? SortBy { get; set; } = null;
        // 是否為遞減排序
        public bool IsDecsending { get; set; } = false;
        // 目前頁碼
        public int PageNumber { get; set; } = 1;
        // 每頁筆數
        public int PageSize { get; set; } = 20;
    }
}
