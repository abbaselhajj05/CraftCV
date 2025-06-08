using CVCraft.Data;
using CVCraft.Models.ViewModels;
using CVCraft.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<ICVInfoService, CVInfoService>();
builder.Services.AddScoped<IArithmeticService, ArithmeticService>();
builder.Services.AddScoped<IFileUploadService, FileUploadService>();
builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("CVs"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapGet("/nationalities", () => new CVCreateViewModel().NationalityOptions);

app.MapGet("/cvs", async ([FromServices] ICVInfoService service) =>
{
    return await service.GetAllAsync();
});

app.Run();
