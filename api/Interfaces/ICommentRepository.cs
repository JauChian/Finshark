using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    // 評論資料存取介面
    public interface ICommentRepository
    {
        // 取得所有評論
        Task<List<Comment>> GetAllAsync();
        // 依 ID 取得評論
        Task<Comment?> GetByIdAsync(int id);
        // 建立評論
        Task<Comment> CreateAsync(Comment commentModel);
        // 更新評論
        Task<Comment?> UpdateAsync(int id, Comment commentModel);
        // 刪除評論
        Task<Comment?> DeleteAsync(int id);
    }
}
