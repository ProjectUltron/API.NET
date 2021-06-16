using System.Collections.Generic;
using System.Threading.Tasks;
using API.NET.Domain.Models;
using API.NET.Domain.Services.Communication;

namespace API.NET.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(Category category);
    }
}
