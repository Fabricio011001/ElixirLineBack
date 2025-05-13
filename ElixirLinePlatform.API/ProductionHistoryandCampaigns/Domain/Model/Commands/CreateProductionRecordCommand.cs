namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Commands;

public record CreateProductionRecordCommand(Guid BatchId, 
    DateTime StartDate,
    DateTime EndDate,
    float VolumeProduced,
    Dictionary<string, float> QualityMetrics);