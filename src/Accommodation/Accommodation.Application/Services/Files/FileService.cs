namespace Accommodation.Application.Services.Files;

public class FileService : IFileService
{

    private readonly string MEDIA = "media";
    private readonly string AVATARS = "avatars";
    private readonly string IMAGES = "images";
    private readonly string ROOTPATH;
    public FileService()
    {
        ROOTPATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    }

    public async ValueTask<bool> DeleteAvatarAsync(string file)
    {
        return await DeleteImageAsync(file);
    }

    public async ValueTask<bool> DeleteImageAsync(string file)
    {
        string path = Path.Combine(ROOTPATH, file);
        if (File.Exists(path))
        {
            await Task.Run(() =>
            {
                File.Delete(path);
            });
            return true;
        }
        return false;

    }

    public async ValueTask<string> UploadAvatarAsync(IFormFile file)
    {
        string newAvatarName = MediaHelper.MakeImageName(file.FileName.ToLower());
        string subPath = Path.Combine(MEDIA, AVATARS, newAvatarName);
        string path = Path.Combine(ROOTPATH, subPath);

        using (var stream = new FileStream(path, FileMode.Create))
        {
            await file.CopyToAsync(stream);
            return subPath;
        }
    }

    public async ValueTask<string> UploadImageAsync(IFormFile file)
    {
        string newImageName = MediaHelper.MakeImageName(file.FileName.ToLower());
        string subPath = Path.Combine(MEDIA, IMAGES, newImageName);
        string path = Path.Combine(ROOTPATH, subPath);

        using (var stream = new FileStream(path, FileMode.Create))
        {
            await file.CopyToAsync(stream);
            return subPath;
        }
    }
}