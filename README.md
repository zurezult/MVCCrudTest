## Dotnet 6.0

# VS Code Extensions
- Bracket Pair colorize (CoenraadS)
- C# (Microsoft)
- C# Extensions (JosKreativ)
- Material Icon Theme (Philipp Kief)
- NuGet Gallery (pcisio)
- SQLite (alexcvzz)

### Setup a .Net model in Studio
# Whats in dotnet
- dotnet --info                                     --> 6.0.202
- dotnet net -l

# install:
* Make the solution file
- dotnet new sln 
- dotnet new mvc
- dotnet sln add .
- dotnet sln list
- dotnet new gitignore
For migration:
- dotnet tool list --global                         --> info
- dotnet tool install --global dotnet-ef --version 6.0.2
- dotnet ef -h                                      --> info in new CMD not in terminal!
- dotnet ef migrations add InitialCreate            --> in CMD!
- dotnet ef database update                         --> in CMD!




# VSCode
- autosave
- generate assets for build and debug
- lookat Properties and delete https for development, then start via terminal --> dotnet run or dotnet watch run

# NuGet
- Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation" Version="6.0.2"
- Microsoft.EntityFrameworkCore" Version="6.0.2"
- Microsoft.EntityFrameworkCore.Sqlite" Version="6.0.2"

# Layout
- Bootswatch.com : Solar
    download Css into new file bootswatchTheme.css and remove btn-primary and a from existing css (_layout)
    getbootstrap.com:    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    icons.getbootstrap.com go to install and copy the CDN:
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.1/font/bootstrap-icons.css">


