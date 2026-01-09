using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Helpers;
using api.Models;

namespace api.Interfaces
{
    // 股票資料存取介面
    public interface IStockRepository
    {
        // 取得股票清單（可帶查詢條件）
        Task<List<Stock>> GetAllAsync(QueryObject query);
        // 依 ID 取得股票
        Task<Stock?> GetByIdAsync(int id);
        // 依代號取得股票
        Task<Stock?> GetBySymbolAsync(string symbol);
        // 建立股票
        Task<Stock> CreateAsync(Stock stockModel);
        // 更新股票
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        // 刪除股票
        Task<Stock?> DeleteAsync(int id);
        // 檢查股票是否存在
        Task<bool> StockExists(int id);
    }
}
