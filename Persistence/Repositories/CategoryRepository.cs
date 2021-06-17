using System.Collections.Generic;
using System.Threading.Tasks;
using API.NET.Domain.Models;
using API.NET.Domain.Repositories;
using API.NET.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace API.NET.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task AddAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
        }
    }
}
