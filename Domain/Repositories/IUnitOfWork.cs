using System.Threading.Tasks;

namespace API.NET.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
