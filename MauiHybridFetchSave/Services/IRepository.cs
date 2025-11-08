using System.Collections.Generic;
using System.Threading.Tasks;
using MauiHybridFetchSave.Models;

namespace MauiHybridFetchSave.Services
{
    public interface IRepository
    {
        Task InitAsync();
        Task InsertAllAsync(IEnumerable<Post> items);
        Task<List<Post>> GetAllAsync();
    }
}

