using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Entities;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Repositories;
using ElixirLinePlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using ElixirLinePlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Infrastructure.Persistence.EFC.Repositories;

public class ProductionRecordRepository(AppDbContext context) : BaseRepository<ProductionRecord>(context), IProductionRecordRepository
{
    private IProductionRecordRepository _productionRecordRepositoryImplementation;

    public async Task<ProductionRecord> GetProductionRecordByIdAsync(Guid recordId)
    {
        return await Context.Set<ProductionRecord>().FirstOrDefaultAsync(productionrecord => productionrecord.RecordId == recordId);
    }

    public async Task<IEnumerable<ProductionRecord>> GetAllProductionRecordsByBatchIdAsync(Guid batchId)
    {
        return await Context.Set<ProductionRecord>()
            .Where(r => r.BatchId == batchId)
            .ToListAsync();
    }
}