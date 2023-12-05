namespace Accommodation.Application.Services.Files;

public interface IFileService
{
    public ValueTask<string> UploadImageAsync(IFormFile file);
    public ValueTask<bool> DeleteImageAsync(string file);
    public ValueTask<string> UploadAvatarAsync(IFormFile file);
    public ValueTask<bool> DeleteAvatarAsync(string file);
}


