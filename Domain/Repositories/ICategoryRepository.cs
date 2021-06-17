using System.Collections.Generic;
using System.Threading.Tasks;
using API.NET.Domain.Models;

namespace API.NET.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
    }
}
