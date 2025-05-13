using System.Net.Mime;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Model.Queries;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Domain.Services;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Interfaces.REST.Resources;
using ElixirLinePlatform.API.ProductionHistoryandCampaigns.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ElixirLinePlatform.API.ProductionHistoryandCampaigns.Interfaces.REST;


[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Available Production History Endpoints")]
public class ProductionRecordController(IProductionRecordQueryService productionRecordQueryService, IProductionRecordCommandService productionRecordCommandService): ControllerBase
{
    //=========== GET BATCH BY GUID
    [HttpGet("{id:guid}")]
    [SwaggerOperation(
        Summary = "Get a Production Record by id",
        Description = "Get a Production by id",
        OperationId = "GetProductionRecordById"
    )]
    [SwaggerResponse(StatusCodes.Status200OK, "The Production Record was successfully retrieved", typeof(ProductionRecordResource))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "The Batch was not found")]
    public async Task<IActionResult> GetProductionRecordById([FromRoute] Guid id)
    {
        var getProductionRecordByIdQuery = new GetProductionRecordByIdQuery(id);
        var productionRecord = await productionRecordQueryService.Handle(getProductionRecordByIdQuery);
        
        if (productionRecord == null)
        {
            return NotFound();
        }

        var productionRecordResource = ProductionRecordFromEntityAssembler.ToResourceFromEntity(productionRecord);
        
        return Ok(productionRecordResource);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProductionRecord([FromBody] CreateProductionRecordResource resource)
    {
        var createProductionRecordCommand = CreateProductionRecordCommandFromResourceAssembler.ToCommandFromResource(resource);
        var productionRecord = await productionRecordCommandService.Handle(createProductionRecordCommand);
        
        if (productionRecord == null)
        {
            return BadRequest("Failed to create production record");
        }
        
        var productionRecordResource = ProductionRecordFromEntityAssembler.ToResourceFromEntity(productionRecord);
        return CreatedAtAction(nameof(GetProductionRecordById), new { id = productionRecordResource.RecordId }, productionRecordResource);
        
    }
}