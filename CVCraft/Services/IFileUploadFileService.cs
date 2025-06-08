namespace CVCraft.Services {
    public interface IFileUploadService {
        Task<string> UploadAsync(IFormFile file, string folderName);
    }

}
