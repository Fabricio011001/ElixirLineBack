using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Entities;

namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Aggregate;

public class BatchHistory
{
    public Guid HistoryId { get; set; }
    public Guid BatchId { get; private set; }
    public List<ProductionRecord> ProductionRecords { get; private set; }
    public double TotalProduced { get; private set; }

    public BatchHistory(Guid batchId)
    {
        HistoryId = Guid.NewGuid();
        BatchId = batchId;
        ProductionRecords = new List<ProductionRecord>();
        TotalProduced = 0;
    }

    public void AddProductionRecord(ProductionRecord productionRecord)
    {
        ProductionRecords.Add(productionRecord);
        CalculateTotalProduced();
    }
    
    
    public void CalculateTotalProduced()
    {
        TotalProduced = ProductionRecords.Sum(record => record.VolumeProduced);
    }

    public List<ProductionRecord> GetProductionRecords()
    {
        return ProductionRecords;
    }
    
    
}