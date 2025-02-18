using optical_character_recognition.Service.Interface;
using Tesseract;

namespace optical_character_recognition.Service.Service
{
    public class ExtractTextService : IExtractTextService
    {
        public ExtractTextService() { }

        public async Task<string> ExtractTextFromImage(byte[] imageBytes)
        {
            string tessDataPath = @"./tessdata";
            using (var engine = new TesseractEngine(tessDataPath, "eng", EngineMode.Default))
            using (var img = Pix.LoadFromMemory(imageBytes))
            using (var page = engine.Process(img))
            {
                return await Task.FromResult(page.GetText());
            }
        }
    }
}
