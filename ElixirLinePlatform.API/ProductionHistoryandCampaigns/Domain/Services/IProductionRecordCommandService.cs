using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Commands;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Entities;

namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Services;

public interface IProductionRecordCommandService
{
    Task<ProductionRecord?> Handle(CreateProductionRecordCommand command);
}