using CGMMiddleWare.Models;
using CGMMiddleWare.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace CGMMiddleWare.Repository.Operations
{
    public class DealRepository : IDealRepository
    {
        private readonly DigiteamDevContext _dbContext;

        public DealRepository(DigiteamDevContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Deal>> GetAllDealsAsync(CancellationToken token)
        {
            return await _dbContext.Deals.ToListAsync(token);
        }

        public async Task<List<Deal>> GetOpenDealsAsync(CancellationToken token)
        {
            return await _dbContext.Deals.Take(1).ToListAsync(token);
        }
    }

}
