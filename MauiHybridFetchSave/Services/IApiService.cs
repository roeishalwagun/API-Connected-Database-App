using System.Collections.Generic;
using System.Threading.Tasks;
using MauiHybridFetchSave.Models;

namespace MauiHybridFetchSave.Services
{
    public interface IApiService
    {
        Task<List<Post>> FetchPostsAsync();
    }
}
