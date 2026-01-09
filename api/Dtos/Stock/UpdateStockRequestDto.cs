using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Stock
{
    // 更新股票的請求 DTO
    public class UpdateStockRequestDto
    {
        // 股票代號
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 over characters")]
        public string Symbol { get; set; } = string.Empty;
        // 公司名稱
        [Required]
        [MaxLength(10, ErrorMessage = "Company Name cannot be over 10 over characters")]
        public string CompanyName { get; set; } = string.Empty;
        // 購入價格
        [Required]
        [Range(1, 1000000000)]
        public decimal Purchase { get; set; }
        // 最近一次股利
        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }
        // 產業類別
        [Required]
        [MaxLength(10, ErrorMessage = "Industry cannot be over 10 characters")]
        public string Industry { get; set; } = string.Empty;
        // 市值
        [Range(1, 5000000000)]
        public long MarketCap { get; set; }
    }
}
