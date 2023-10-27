using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SimpleUI;
using Refit;
using SimpleUI.DataAccess;

// https://localhost:7171/ from api project

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddRefitClient<IGuestData>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://localhost:7171/api");
});

await builder.Build().RunAsync();
