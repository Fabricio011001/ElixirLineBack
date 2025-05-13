namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Interfaces.REST.Resources;

public record ProductionRecordResource(
    Guid RecordId,
    Guid BatchId,
    DateTime StartDate,
    DateTime EndDate,
    float VolumeProduced,
    Dictionary<string, float> QualityMetrics
);