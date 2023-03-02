using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace fhircsdatabases;

// "/[base]/[type]/[id]"
// "/fhir/[type]"

[ApiController]
[Route("[controller]")]
public class FhirController
{

    [HttpGet("{resourceName}/{id}", Name="instanceRead")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/fhir+json")]
    public ActionResult getTypeId([FromRoute] string resourceName, [FromRoute] string id)
    {
        if (string.IsNullOrEmpty(resourceName) || string.IsNullOrEmpty(id))
        {
            return new NotFoundResult();
        }
        
        return new NotFoundResult();
    }
    
    [HttpGet("metadata", Name="getMetadata")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/fhir+json")]
    public ActionResult getMetadata([FromRoute] string resourceName, [FromRoute] string id)
    {
        return new BadRequestResult();
    }
    
    [HttpDelete("{resourceName}/{id}", Name="instanceDelete")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/fhir+json")]
    public ActionResult deleteTypeId([FromRoute] string resourceName, [FromRoute] string id)
    {
        if (string.IsNullOrEmpty(resourceName) || string.IsNullOrEmpty(id))
        {
            return new NotFoundResult();
        }

        return new NotFoundResult();
    }
    
    [HttpPost("{resourceName}", Name="typeCreate")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/fhir+json")]
    public ActionResult postType()
    {
        return new BadRequestResult();
    }
    
    [HttpPut("{resourceName}/{id}", Name="instanceUpdateOrDelete")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/fhir+json")]
    public ActionResult putTypeId([FromRoute] string resourceName, [FromRoute] string id)
    {
        return new BadRequestResult();
    }
    
    [HttpGet("{resourceName}", Name="getTypeSearch")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/fhir+json")]
    public ActionResult getType([FromRoute] string resourceName)
    {
        return new NotFoundResult();
    }
    
    [HttpPost("{resourceName}/_search", Name="postTypeSearch")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/fhir+json")]
    public ActionResult postTypeSearch()
    {
        return new BadRequestResult();
    }
    
    public string? Summary { get; set; }
}