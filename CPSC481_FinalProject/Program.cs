using CPSC481_FinalProject;
using CPSC481_FinalProject.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.Toast;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICourseState, CourseState>();
builder.Services.AddScoped<IAdvancedSearchState, advancedSearchState>();
builder.Services.AddScoped<ITermState, termState>();
builder.Services.AddBlazoredToast();

await builder.Build().RunAsync();

