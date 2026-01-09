using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Helpers;
using api.Models;

namespace api.Interfaces
{
    // Stock repository contract
    public interface IStockRepository
    {
        // Get stocks with query options
        Task<List<Stock>> GetAllAsync(QueryObject query);
        // Get a stock by id
        Task<Stock?> GetByIdAsync(int id);
        // Get a stock by symbol
        Task<Stock?> GetBySymbolAsync(string symbol);
        // Create a stock
        Task<Stock> CreateAsync(Stock stockModel);
        // Update a stock
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        // Delete a stock
        Task<Stock?> DeleteAsync(int id);
        // Check stock existence
        Task<bool> StockExists(int id);
    }
}
