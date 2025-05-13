using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Commands;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Interfaces.REST.Resources;

namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Interfaces.REST.Transform;

public static class UpdateVolumeProducedFromResourceAssembler
{
    public static UpdateVolumeProducedCommand ToCommandFromResource(UpdateVolumeProducedResource resource)
    {
        return new UpdateVolumeProducedCommand(
            resource.RecordId,
            resource.VolumeProduced
        );
    }
}