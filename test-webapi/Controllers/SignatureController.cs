using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace test_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SignatureController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;

        public SignatureController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpGet("{inspectorName}")]
        public IActionResult GetSignature(string inspectorName)
        {
            try
            {
                var signaturePath = Path.Combine(_environment.ContentRootPath, "Signatures", $"{inspectorName.ToLower().Replace(" ", "_")}.jpg");

                if (!System.IO.File.Exists(signaturePath))
                {
                    return NotFound($"Signature not found for {inspectorName}");
                }

                var imageBytes = System.IO.File.ReadAllBytes(signaturePath);
                return File(imageBytes, "image/jpeg");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error retrieving signature: {ex.Message}");
            }
        }
    }
}
