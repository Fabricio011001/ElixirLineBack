using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Entities;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Interfaces.REST.Resources;

namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Interfaces.REST.Transform;

public static class ProductionRecordFromEntityAssembler
{
    public static ProductionRecordResource ToResourceFromEntity(ProductionRecord entity)
    {
        return new ProductionRecordResource(
            entity.RecordId,
            entity.BatchId,
            entity.StartDate,
            entity.EndDate,
            entity.VolumeProduced,
            entity.QualityMetrics
        );
    }
}