using Hospital.Application.Services.Helpers;

using Microsoft.AspNetCore.Http;

namespace Hospital.Application.Services.Files;

public class FileService : IFileService
{
    private readonly string MEDIA = "media";
    private readonly string IMAGES = "images";
    private readonly string AVATARS = "avatars";
    private readonly string ROOTPATH;

    public FileService()
    {
        ROOTPATH = @"C:\\Users\\USER\\Desktop\\ExamProject\\microservice\\src\\Accommodation\\Accommodation.Presentation\\wwwroot";
    }

    public async ValueTask<bool> DeleteAvatarAsync(string subpath)
    {
        string path = Path.Combine(ROOTPATH, subpath);
        if (File.Exists(path))
        {
            await Task.Run(() =>
            {
                File.Delete(path);
            });
            return true;
        }
        else return false;
    }

    public async ValueTask<bool> DeleteImageAsync(string subpath)
    {
        string path = Path.Combine(ROOTPATH, subpath);
        if (File.Exists(path))
        {
            await Task.Run(() =>
            {
                File.Delete(path);
            });
            return true;
        }
        else return false;
    }

    public async ValueTask<string> UploadAvatarAsync(IFormFile avatar)
    {
        string newImageName = MediaHelper.MakeImageName(avatar.FileName);
        string subpath = Path.Combine(MEDIA, AVATARS, newImageName);
        string path = Path.Combine(ROOTPATH, subpath);

        var stream = new FileStream(path, FileMode.Create);
        await avatar.CopyToAsync(stream);
        stream.Close();

        return subpath;
    }

    public async ValueTask<string> UploadImageAsync(IFormFile image)
    {
        string newImageName = MediaHelper.MakeImageName(image.FileName);
        string subpath = Path.Combine(MEDIA, IMAGES, newImageName);
        string path = Path.Combine(ROOTPATH, subpath);

        var stream = new FileStream(path, FileMode.Create);
        await image.CopyToAsync(stream);
        stream.Close();

        return subpath;
    }
}
