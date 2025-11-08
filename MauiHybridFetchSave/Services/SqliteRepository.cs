using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using MauiHybridFetchSave.Models;
using Microsoft.Maui.Storage;
using SQLite;

namespace MauiHybridFetchSave.Services
{
    public class SqliteRepository : IRepository
    {
        private readonly SQLiteAsyncConnection _db;
        private readonly string _dbPath;

        public SqliteRepository()
        {
            _dbPath = Path.Combine(FileSystem.AppDataDirectory, "appdata.db3");
            _db = new SQLiteAsyncConnection(_dbPath);
        }

        public async Task InitAsync()
        {
            await _db.CreateTableAsync<Post>();
        }

        public async Task InsertAllAsync(IEnumerable<Post> items)
        {
            await _db.DeleteAllAsync<Post>();
            await _db.InsertAllAsync(items);
        }

        public async Task<List<Post>> GetAllAsync()
        {
            return await _db.Table<Post>().ToListAsync();
        }

        public string GetDatabasePath() => _dbPath;
    }
}

