using CVCraft.Data;
using CVCraft.DTOs;
using CVCraft.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace CVCraft.Services {
    public class CVInfoService(AppDbContext context) : ICVInfoService {
        public readonly AppDbContext _context = context;
        public async Task<Guid> AddCVAsync(CreateCVInfoCommand cmd) {
            var cvInfo = cmd.ToCVInfo();
            await _context.CVInfos.AddAsync(cvInfo);
            await _context.SaveChangesAsync();
            return cvInfo.Id;
        }
        public async Task<CVInfo?> GetCV(Guid Id) {
            return await _context.CVInfos
                .Where(cv => cv.Id == Id)
                .FirstOrDefaultAsync();
        }
        public async Task<List<CVInfo>> GetAllAsync() => await _context.CVInfos.ToListAsync();

        public async Task<bool> TryUpdateCV(UpdateCVInfoCommand cmd) {
            CVInfo? cvInfo = await GetCV(cmd.Id);
            if (cvInfo is null)
                return false;
            cmd.UpdateCV(cvInfo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> TryDeleteCV(Guid Id) {
            CVInfo? cvInfo = await GetCV(Id);
            if (cvInfo is null)
                return false;
            cvInfo.IsDeleted = true;
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
