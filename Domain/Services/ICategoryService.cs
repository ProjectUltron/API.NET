using System.Collections.Generic;
using System.Threading.Tasks;
using API.NET.Domain.Models;

namespace API.NET.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
