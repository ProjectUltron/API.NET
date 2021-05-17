using System.Collections.Generic;
using System.Threading.Tasks;
using API.NET.Domain.Models;
using API.NET.Domain.Repositories;
using API.NET.Domain.Services;

namespace API.NET.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
