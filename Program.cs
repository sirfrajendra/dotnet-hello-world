using dotnet_hello_world.Components;

var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel before building the app
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(80);
});

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Skip HTTPS inside container (HTTPS terminates at load balancer or gateway)
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
