using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    // Portfolio repository contract
    public interface IPortfolioRepository
    {
        // Get portfolio for a user
        Task<List<Stock>> GetUserPortfolio(AppUser user);
        // Create a portfolio entry
        Task<Portfolio> CreateAsync(Portfolio portfolio);
        // Delete a portfolio entry
        Task<Portfolio> DeletePortfolio(AppUser appUser, string symbol);
    }
}
