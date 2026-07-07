# 📄 Resume Web Profile

A personal resume portfolio website built with ASP.NET Core 9.0 MVC, designed to showcase personal information, work experience, skills, and projects.

## 🚀 Tech Stack

- **Backend Framework**: ASP.NET Core 9.0
- **Frontend**: Razor Views + CSS
- **Architecture**: MVC (Model-View-Controller)
- **Development Tools**: Visual Studio 2022 / .NET CLI

## 📋 Features

- ✅ Personal profile display
- ✅ Work experience showcase
- ✅ Education background
- ✅ Skills tags
- ✅ Responsive design
- ✅ Contact form

## 🛠️ Local Setup

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Visual Studio 2022 or VS Code

### Run Locally

```bash
# 1. Clone the repository
git clone https://github.com/Alex9989286/ResumeWebProfile-Assignment.git

# 2. Navigate to project directory
cd ResumeWebProfile-Assignment

# 3. Restore dependencies
dotnet restore

# 4. Run the application
dotnet run
```

Open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`

## 📁 Project Structure

```
ResumeWebProfile-Assignment/
├── Controllers/              # Controllers
│   └── HomeController.cs
├── Properties/               # Project properties
│   └── launchSettings.json
├── Views/                    # Views
│   ├── Home/
│   │   ├── Index.cshtml      # Home page
│   │   ├── About.cshtml      # About me
│   │   ├── Contact.cshtml    # Contact form
│   │   └── Workexperience.cshtml # Work experience
│   └── Shared/
│       └── _Layout.cshtml    # Layout template
├── wwwroot/                  # Static files
│   ├── css/                  # Stylesheets
│   ├── images/               # Images
│   └── js/                   # JavaScript files
├── Program.cs                # Entry point
├── LayoutDemo.csproj         # Project file
├── appsettings.json          # Configuration
└── appsettings.Development.json # Development config
```

## 📝 Page Navigation

| Page | Route | Description |
|------|-------|-------------|
| Home | `/` | Personal introduction and welcome |
| About | `/Home/About` | Detailed personal information |
| Work Experience | `/Home/Workexperience` | Career history and achievements |
| Contact | `/Home/Contact` | Contact form |

## 🌐 Deployment

### Option 1: Deploy to IIS (Windows Server)

```bash
# Publish the application
dotnet publish -c Release -o ./publish
```

Then:
1. Open IIS Manager
2. Right-click **Sites** → **Add Website**
3. Set:
   - Site name: `ResumeWebProfile`
   - Physical path: `./publish` folder
   - Port: `80` (HTTP) or `443` (HTTPS)
4. Set Application Pool:
   - .NET CLR version: **No Managed Code**
   - Managed pipeline mode: **Integrated**

### Option 2: Deploy to Azure Cloud

#### Using Azure CLI:
```bash
# Login to Azure
az login

# Create App Service
az appservice plan create --name MyPlan --resource-group MyResourceGroup --sku FREE
az webapp create --name ResumeWebProfile --resource-group MyResourceGroup --plan MyPlan --runtime "DOTNET:9.0"

# Deploy
dotnet publish -c Release -o ./publish
cd publish
zip -r publish.zip *
az webapp deployment source config-zip --resource-group MyResourceGroup --name ResumeWebProfile --src publish.zip
```

#### Using Visual Studio (Recommended):
1. Right-click project → **Publish**
2. Select **Azure** → **Azure App Service**
3. Follow the wizard to deploy
4. Access at: `https://your-app-name.azurewebsites.net`

### Option 3: Deploy to Render (Free Alternative)

1. Push code to GitHub
2. Go to [Render.com](https://render.com)
3. Click **New +** → **Web Service**
4. Connect your GitHub repository
5. Set:
   - Build Command: `dotnet publish -c Release -o ./publish`
   - Start Command: `dotnet ./publish/LayoutDemo.dll`
6. Click **Create Web Service**


## 📸 Screenshots

### Home Page
<img width="1918" height="967" alt="Screenshot 2026-07-07 173312" src="https://github.com/user-attachments/assets/64fbec65-31e5-4c8b-97a2-8f0dad85cce7" />


### About Page
<img width="1918" height="868" alt="Screenshot 2026-07-07 173335" src="https://github.com/user-attachments/assets/7c1aa482-36c8-4c71-b997-75336f0ebd5a" />


### Work Experience Page
<img width="1918" height="965" alt="Screenshot 2026-07-07 173345" src="https://github.com/user-attachments/assets/a8181396-eb8c-477f-a62c-42bfd6adc55f" />


### Contact Page
<img width="1918" height="918" alt="Screenshot 2026-07-07 173356" src="https://github.com/user-attachments/assets/88e2b458-22b9-4062-9a66-5273d0358d54" />


## 👨‍💻 Author

- **GitHub**: [Alex9989286](https://github.com/Alex9989286)
- **Email**: jianshengalexng17317@gmail.com

## 📄 License

This project is for educational purposes only

## 🙏 Acknowledgments

- [ASP.NET Core Documentation](https://docs.microsoft.com/aspnet/core)
- [Bootstrap](https://getbootstrap.com)
- [Font Awesome](https://fontawesome.com)
