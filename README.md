# CraftCV

**CraftCV** is a powerful, cleanly architected ASP.NET Core MVC web application that allows users to create and manage resumes with ease. The project demonstrates solid backend development, full CRUD functionality, and a strong separation of concerns between models, views, and controllers.

## 🚀 Features

- 🔁 Full **CRUD operations** for CV entries (Create, Read, Update, Delete)
- 🧠 **Strong backend architecture** using ASP.NET Core
- 🔍 Clear **separation of concerns**:
  - Models handle data and validation
  - Controllers manage logic
  - Views focus on presentation
- 📁 Local file upload support (e.g., profile pictures in `wwwroot/uploads`)
- ⚙️ Easy to maintain and extend for future features

## 🛠️ Tech Stack

- **Backend:** ASP.NET Core MVC
- **Frontend:** Razor Views, HTML/CSS, Bootstrap (if used)
- **Persistence:** Entity Framework Core (if used)
- **Others:** C#, LINQ, RESTful architecture

## 📦 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/abbaselhajj05/CraftCV.git
cd CraftCV
````

### 2. Open the project in Visual Studio

* Restore NuGet packages via the package manager
* Set the appropriate startup project

### 3. Run the application

```bash
dotnet run
```

* Open your browser at: `http://localhost:5000`

## 🧱 Project Structure

```
CVCraft/
│   appsettings.json
│   appsettings.Development.json
│   CVCraft.csproj
│   CVCraft.csproj.user
│   Program.cs
│
├── bin/Debug/net8.0/
│   ├── CVCraft.exe, CVCraft.dll, etc.
│   ├── Homework5.exe, Homework5.dll, etc.
│   └── Various runtime and dependency files
│
├── Data/
│   └── AppDbContext.cs
│
├── DTOs/
│   ├── CreateCVInfoCommand.cs
│   ├── EditCVBase.cs
│   └── UpdateCVInfoCommand.cs
│
├── Mappers/
│   └── CVMapper.cs
│
├── Models/
│   ├── BindingModels/
│   │   ├── CVCreateBindingModel.cs
│   │   └── CVEditBindingModel.cs
│   │
│   ├── Entities/
│   │   └── CVInfo.cs
│   │
│   └── ViewModels/
│       ├── CVCreateViewModel.cs
│       ├── CVEditViewModel.cs
│       └── CVSummaryViewModel.cs
│
├── obj/
│   └── Build outputs and intermediate files
│
├── Pages/
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── _Layout.cshtml.css
│   │   └── _ValidationScriptsPartial.cshtml
│   │
│   ├── CreateCV.cshtml (+ .cs)
│   ├── EditCV.cshtml (+ .cs)
│   ├── Index.cshtml (+ .cs)
│   ├── ManageCVs.cshtml (+ .cs)
│   ├── Success.cshtml (+ .cs)
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
│
├── Properties/
│   └── launchSettings.json
│
├── Services/
│   ├── IArithmeticService.cs
│   ├── ICVInfoService.cs
│   ├── IFileUploadFileService.cs
│   ├── ArithmeticService.cs
│   ├── CVInfoService.cs
│   └── FileUploadService.cs
│
└── wwwroot/
    ├── favicon.ico
    ├── css/
    │   └── site.css
    ├── js/
    │   └── site.js
    └── lib/
        ├── bootstrap/
        └── jquery/

```

## 👤 Author

* **Abbas El Hajj** — [GitHub Profile](https://github.com/abbaselhajj05)

## 📃 License

This project is licensed under the MIT License — feel free to use and modify.
