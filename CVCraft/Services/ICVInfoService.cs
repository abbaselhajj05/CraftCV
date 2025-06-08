using CVCraft.Data;
using CVCraft.DTOs;
using CVCraft.Models.Entities;

namespace CVCraft.Services {
    public interface ICVInfoService {
        public Task<Guid> AddCVAsync(CreateCVInfoCommand cmd);
        public Task<CVInfo?> GetCV(Guid Id);
        public Task<List<CVInfo>> GetAllAsync();
        public Task<bool> TryUpdateCV(UpdateCVInfoCommand cmd);
        public Task<bool> TryDeleteCV(Guid Id);

    }
}
