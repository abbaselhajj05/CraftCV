using CVCraft.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

public class FileUploadService : IFileUploadService {
    private readonly IWebHostEnvironment _environment;

    public FileUploadService(IWebHostEnvironment environment) {
        _environment = environment;
    }

    public async Task<string> UploadAsync(IFormFile file, string folderName) {
        if (file == null || file.Length == 0)
            throw new ArgumentException("Invalid file.");

        var uploadsPath = Path.Combine(_environment.WebRootPath, folderName);

        if (!Directory.Exists(uploadsPath)) {
            Directory.CreateDirectory(uploadsPath);
        }

        // Optional: Make the file name unique
        var uniqueFileName = $"{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}";
        var filePath = Path.Combine(uploadsPath, uniqueFileName);

        using (var stream = new FileStream(filePath, FileMode.Create)) {
            await file.CopyToAsync(stream);
        }

        return $"/{folderName}/{uniqueFileName}"; // Return relative path to use in views
    }
}
