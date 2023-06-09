using IMS.Domain.Entities;
using IMS.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;


namespace IMS.Application.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GlassesController : ControllerBase
{
    private readonly IRepository<Glasses> _repository;

    public GlassesController(IRepository<Glasses> repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllGlasses()
    {
        try
        {
            var result = await _repository.GetAllTypesAsync();
            return Ok(result);
        }
        catch (System.Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetGlasses([FromRoute] int id)
    {
        try
        {
            var result = await _repository.GetTypeById(id);
            return Ok(result);
        }
        catch (System.Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> InsertType(Glasses newGlasses)
    {
        try
        {
            if (newGlasses == null)
                throw new Exception("O valor está incorreto");

            await _repository.InsertType(newGlasses);
            return Created(Request.GetEncodedUrl + "/" + newGlasses.Id, newGlasses);
        }
        catch (System.Exception e)
        {
            throw new Exception(e.Message);
        }
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateType([FromRoute] int id, Glasses newGlasses)
    {
        try
        {
            await _repository.UpdateType(newGlasses);
            return Ok(newGlasses);
        }
        catch (System.Exception e)
        {
            throw new Exception(e.Message);
        }
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveType([FromRoute] int id)
    {
        try
        {
            var result = await _repository.GetTypeById(id);
            _repository.RemoveType(result);
            return Ok();
        }
        catch (System.Exception e)
        {
            throw new Exception(e.Message);
        }
    }

}
