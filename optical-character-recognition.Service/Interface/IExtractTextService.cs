namespace optical_character_recognition.Service.Interface
{
    public interface IExtractTextService
    {
        Task<string> ExtractTextFromImage(byte[] imageBytes);
    }
}
