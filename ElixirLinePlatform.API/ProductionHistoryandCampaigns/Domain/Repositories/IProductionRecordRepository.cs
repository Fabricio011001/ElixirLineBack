using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Entities;
using ElixirLinePlatform.API.Shared.Domain.Repositories;

namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Repositories;

public interface IProductionRecordRepository : IBaseRepository<ProductionRecord>
{
    Task<ProductionRecord> GetProductionRecordByIdAsync(Guid recordId);
    Task<IEnumerable<ProductionRecord>> GetAllProductionRecordsByBatchIdAsync(Guid batchId);
}