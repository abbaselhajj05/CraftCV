# CraftCV

**CraftCV** is a powerful, cleanly architected ASP.NET Core Razor Pages web application that allows users to create and manage resumes with ease. The project demonstrates solid backend development, full CRUD functionality, and a strong separation of concerns between models, views, and page logic.

## 🚀 Features

- 🔁 Full **CRUD operations** for CV entries (Create, Read, Update, Delete)
- 🧠 **Robust backend architecture** using ASP.NET Core Razor Pages
- 🔍 Clear **separation of concerns**:
  - Models handle data and validation
  - Page models manage logic and routing
  - Views focus on presentation
- 📁 Local file upload support (e.g., profile pictures in `wwwroot/uploads`)
- ⚙️ Easy to maintain and extend for future features

## 🛠️ Tech Stack

- **Backend:** ASP.NET Core Razor Pages
- **Frontend:** Razor Views, HTML/CSS, Bootstrap
- **Persistence:** Entity Framework Core
- **Languages/Tools:** C#, LINQ

## 📦 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/abbaselhajj05/CraftCV.git
cd CraftCV
```

### 2. Open the project in Visual Studio

- Restore NuGet packages via the package manager
- Set the appropriate startup project

### 3. Run the application

```bash
dotnet run
```

- Open your browser at: `http://localhost:5000`

## 🧱 Project Structure

```
CVCraft/
├── appsettings.json
├── appsettings.Development.json
├── CVCraft.csproj
├── Program.cs
│
├── bin/Debug/net8.0/
│   ├── CVCraft.exe
│   ├── CVCraft.dll
│   └── Other runtime files
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
│   ├── Entities/
│   │   └── CVInfo.cs
│   └── ViewModels/
│       ├── CVCreateViewModel.cs
│       ├── CVEditViewModel.cs
│       └── CVSummaryViewModel.cs
│
├── Pages/
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   └── _ValidationScriptsPartial.cshtml
│   ├── CreateCV.cshtml
│   ├── EditCV.cshtml
│   ├── Index.cshtml
│   ├── ManageCVs.cshtml
│   └── Success.cshtml
│
├── Properties/
│   └── launchSettings.json
│
├── Services/
│   ├── IArithmeticService.cs
│   ├── ICVInfoService.cs
│   ├── IFileUploadFileService.cs
│   ├── ArithmeticService.cs
│   └── CVInfoService.cs
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

- **Abbas El-Hajj Youssef** — [GitHub Profile](https://github.com/abbaselhajj05)

## 📃 License

This project is licensed under the MIT License — feel free to use and modify.
