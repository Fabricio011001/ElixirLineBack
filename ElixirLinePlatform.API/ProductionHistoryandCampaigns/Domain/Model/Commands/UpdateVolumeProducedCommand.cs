namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Commands;

public record UpdateVolumeProducedCommand(Guid RecordId, float VolumeProduced);