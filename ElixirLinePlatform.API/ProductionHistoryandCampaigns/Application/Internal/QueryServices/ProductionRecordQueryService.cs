using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Entities;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Queries;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Repositories;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Services;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Infrastructure.Persistence.EFC.Repositories;

namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Application.Internal.QueryServices;

public class ProductionRecordQueryService(IProductionRecordRepository productionRecordRepository) : IProductionRecordQueryService
{
    public async Task<ProductionRecord?> Handle(GetProductionRecordByIdQuery query)
    {
        return await productionRecordRepository.GetProductionRecordByIdAsync(query.RecordID);
    }

    public async Task<IEnumerable<ProductionRecord>> Handle(GetAllProductionRecordsByBatchIdQuery query)
    {
        return await productionRecordRepository.GetAllProductionRecordsByBatchIdAsync(query.BatchId);
    }
}
  