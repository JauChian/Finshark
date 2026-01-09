using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Interfaces;
using api.Models;
using api.Data;
using api.Dtos.Comment;
using System.Security.Cryptography.X509Certificates;


namespace api.Repository
{
    // Comment repository implementation
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;
        // DI constructor
        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        // Create a comment
        public async Task<Comment> CreateAsync(Comment commentModel)
        {
            await _context.Comments.AddAsync(commentModel);
            await _context.SaveChangesAsync();
            return commentModel;
        }

        // Delete a comment
        public async Task<Comment?> DeleteAsync(int id)
        {
            var commentModel = await _context.Comments.FirstOrDefaultAsync(x => x.Id == id);

            if (commentModel == null)
            {
                return null;
            }

            _context.Comments.Remove(commentModel);
            await _context.SaveChangesAsync();
            return commentModel;
        }

        // Get all comments
        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.Include(a => a.AppUser).ToListAsync();
        }

        // Get a comment by id
        public async Task<Comment?> GetByIdAsync(int id)
        {
            return await _context.Comments.Include(a => a.AppUser).FirstOrDefaultAsync(c => c.Id == id);
        }

        // Update a comment
        public async Task<Comment?> UpdateAsync(int id, Comment commentModel)
        {
            var exitingComment = await _context.Comments.FindAsync(id);

            if (exitingComment == null)
            {
                return null;
            }

            exitingComment.Title = commentModel.Title;
            exitingComment.Content = commentModel.Content;

            await _context.SaveChangesAsync();

            return exitingComment;
        }
    }
}
