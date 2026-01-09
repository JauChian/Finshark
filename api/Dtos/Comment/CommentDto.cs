using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    // 回傳用的評論 DTO
    public class CommentDto
    {
        // 評論 ID
        public int Id { get; set; }
        // 評論標題
        public string Title { get; set; } = string.Empty;
        // 評論內容
        public string Content { get; set; } = string.Empty;
        // 建立時間
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        // 關聯的股票 ID（可為空）
        public int? StockId { get; set; }
    }
}
