using CGMMiddleWare.Models;

namespace CGMMiddleWare.Repository.Interface
{
    public interface IDealRepository
    {
        Task<List<Deal>> GetAllDealsAsync(CancellationToken token);

        Task<List<Deal>> GetOpenDealsAsync(CancellationToken token);

    }
}
