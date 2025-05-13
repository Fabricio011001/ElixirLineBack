using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Commands;

namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Entities;

public class ProductionRecord
{
    public Guid RecordId { get; set; }
    public Guid BatchId { get; set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public float VolumeProduced { get; private set; }
    public Dictionary<string, float> QualityMetrics { get; private set; }

    public ProductionRecord(Guid batchId, DateTime startDate, DateTime endDate, float volumeProduced,
        Dictionary<string, float> qualityMetrics)
    {
        RecordId = Guid.NewGuid();
        BatchId = batchId;
        StartDate = startDate;
        EndDate = endDate;
        VolumeProduced = volumeProduced;
        QualityMetrics = qualityMetrics ?? new Dictionary<string, float>();
    }

    public ProductionRecord(CreateProductionRecordCommand command)
    {
        RecordId = Guid.NewGuid();
        this.BatchId = command.BatchId;
        this.StartDate = command.StartDate;
        this.EndDate = command.EndDate;
        this.VolumeProduced = command.VolumeProduced;
        this.QualityMetrics = command.QualityMetrics;
    }
    
    
    public void UpdateVolumeProduced(float newVolume)
    {
        if (newVolume < 0)
            throw new ArgumentException("Volume produced cannot be negative.");
        
        VolumeProduced = newVolume;
    }
    
    public void AddQualityMetric(string metricName, float value)
    {
        if (QualityMetrics.ContainsKey(metricName))
        {
            QualityMetrics[metricName] = value;
        }
        else
        {
            QualityMetrics.Add(metricName, value);
        }
    }
    
    public void CloseRecord() {}
    
}