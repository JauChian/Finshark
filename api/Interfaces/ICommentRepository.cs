using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    // Comment repository contract
    public interface ICommentRepository
    {
        // Get all comments
        Task<List<Comment>> GetAllAsync();
        // Get a comment by id
        Task<Comment?> GetByIdAsync(int id);
        // Create a comment
        Task<Comment> CreateAsync(Comment commentModel);
        // Update a comment
        Task<Comment?> UpdateAsync(int id, Comment commentModel);
        // Delete a comment
        Task<Comment?> DeleteAsync(int id);
    }
}
