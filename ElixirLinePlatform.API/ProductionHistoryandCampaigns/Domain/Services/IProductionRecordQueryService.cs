using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Entities;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Queries;

namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Services;

public interface IProductionRecordQueryService
{
    Task<ProductionRecord?> Handle(GetProductionRecordByIdQuery query);
    Task<IEnumerable<ProductionRecord>> Handle(GetAllProductionRecordsByBatchIdQuery query);
}