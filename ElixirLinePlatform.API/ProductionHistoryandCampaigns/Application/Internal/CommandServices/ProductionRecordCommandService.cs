using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Commands;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Entities;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Repositories;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Services;
using ElixirLinePlatform.API.Shared.Domain.Repositories;

namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Application.Internal.CommandServices;

public class ProductionRecordCommandService(IProductionRecordRepository productionRecordRepository, IUnitOfWork unitOfWork) : IProductionRecordCommandService
{
    private IProductionRecordRepository _productionRecordRepositoryImplementation;

    public async Task<ProductionRecord?> Handle(CreateProductionRecordCommand command)
    {
        var productionRecord = new ProductionRecord(command);
        
        await productionRecordRepository.AddAsync(productionRecord);
        await unitOfWork.CompleteAsync();
        return productionRecord;
    }
}