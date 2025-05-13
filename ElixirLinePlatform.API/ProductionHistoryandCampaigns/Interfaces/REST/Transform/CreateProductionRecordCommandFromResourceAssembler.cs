using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Commands;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Entities;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Interfaces.REST.Resources;

namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Interfaces.REST.Transform;

public static class CreateProductionRecordCommandFromResourceAssembler
{
    public static CreateProductionRecordCommand ToCommandFromResource(CreateProductionRecordResource resource)
    {
        return new CreateProductionRecordCommand(
            resource.BatchId,
            resource.StartDate,
            resource.EndDate,
            resource.VolumeProduced,
            resource.QualityMetrics);
    }
}