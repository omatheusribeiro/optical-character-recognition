using Microsoft.AspNetCore.Mvc;
using optical_character_recognition.Service.Interface;

namespace optical_character_recognition.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OpticalCharacterRecognitionController : ControllerBase
    {

        private readonly IExtractTextService _extractTextService;

        public OpticalCharacterRecognitionController(IExtractTextService extractTextService)
        {
            _extractTextService = extractTextService;
        }

        [HttpPost]
        [Route("extract-text")]
        public async Task<IActionResult> ExtractText([FromForm] IFormFile imageFile)
        {
            if (imageFile == null || imageFile.Length == 0)
                return BadRequest("No image uploaded.");

            using (var stream = new MemoryStream())
            {
                await imageFile.CopyToAsync(stream);
                var imageBytes = stream.ToArray();

                string extractedText = await _extractTextService.ExtractTextFromImage(imageBytes);
                return Ok(new { text = extractedText });
            }
        }
    }
}
