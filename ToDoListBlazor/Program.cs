using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ToDoListBlazor;
using ToDoListBlazor.Pages.Components; // Import the ErrorManager and FileService namespaces
using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection; // Import this namespace

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register ErrorManager service
builder.Services.AddScoped<ErrorManager>();

// Register FileService as a scoped service
builder.Services.AddScoped<FileService>(sp =>
{
    var baseAddress = builder.HostEnvironment.BaseAddress;
    var filePath = $"{baseAddress}your-file-path"; // Replace with your actual file path
    return new FileService(filePath);
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
