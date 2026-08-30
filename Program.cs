var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content("""
<!DOCTYPE html>
<html>
<head>
    <title>Keval - Azure Experiment 2</title>
</head>

<body>
    <h1>Microsoft Azure App Service</h1>

    <h2>Experiment 2 - Platform as a Service</h2>

    <h3>Name: Keval Kakadiya</h3>

    <p>
        This website has been automatically deployed
        using GitHub Actions.
    </p>

    <p>Azure App Service + GitHub CI/CD</p>

    <h3>CI/CD Deployment Successful</h3>
</body>
</html>
""", "text/html"));

app.Run();
