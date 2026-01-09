using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;

namespace api.Dtos.Stock
{
    // 回傳用的股票 DTO
    public class StockDto
    {
        // 股票 ID
        public int Id { get; set; }
        // 股票代號
        public string Symbol { get; set; } = string.Empty;
        // 公司名稱
        public string CompanyName { get; set; } = string.Empty;
        // 購入價格
        public decimal Purchase { get; set; }
        // 最近一次股利
        public decimal LastDiv { get; set; }
        // 產業類別
        public string Industry { get; set; } = string.Empty;
        // 市值
        public long MarketCap { get; set; }
        // 相關評論
        public List<CommentDto> Comments { get; set; }
    }
}
