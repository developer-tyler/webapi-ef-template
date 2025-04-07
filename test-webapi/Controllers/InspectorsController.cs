using Microsoft.AspNetCore.Mvc;
using test_webapi.DTOs;
using test_webapi.Services;

namespace test_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InspectorsController : ControllerBase
    {
        private readonly IInspectorService _service;

        public InspectorsController(IInspectorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InspectorDto>>> GetAllInspectors()
        {
            var inspectors = await _service.GetAllInspectorsAsync();
            return Ok(inspectors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InspectorDto>> GetInspector(int id)
        {
            var inspector = await _service.GetInspectorByIdAsync(id);
            if (inspector == null)
            {
                return NotFound();
            }
            return Ok(inspector);
        }

        [HttpPost]
        public async Task<ActionResult<InspectorDto>> CreateInspector(InspectorDto inspectorDto)
        {
            var createdInspector = await _service.CreateInspectorAsync(inspectorDto);
            return CreatedAtAction(
                nameof(GetInspector),
                new { id = createdInspector.InspectorID },
                createdInspector);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<InspectorDto>> UpdateInspector(int id, InspectorDto inspectorDto)
        {
            try
            {
                var updatedInspector = await _service.UpdateInspectorAsync(id, inspectorDto);
                return Ok(updatedInspector);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInspector(int id)
        {
            try
            {
                await _service.DeleteInspectorAsync(id);
                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
