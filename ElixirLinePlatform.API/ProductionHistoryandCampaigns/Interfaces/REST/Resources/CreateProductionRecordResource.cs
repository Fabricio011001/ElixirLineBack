namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Interfaces.REST.Resources;


public record CreateProductionRecordResource(
    Guid BatchId,                // Identificador del lote al que pertenece el registro
    DateTime StartDate,          // Fecha de inicio de la producción
    DateTime EndDate,            // Fecha de finalización de la producción
    float VolumeProduced,        // Volumen producido en litros
    Dictionary<string, float> QualityMetrics);

