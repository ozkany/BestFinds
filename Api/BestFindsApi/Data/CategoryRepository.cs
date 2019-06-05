using BestFindsApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestFindsApi.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;
        public CategoryRepository(DataContext context)
        {
            this._context = context;
        }

        public async Task<Category[]> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToArrayAsync();
        }

    }

}
