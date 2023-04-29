using Final_Exam_Project.Client;
using Final_Exam_Project.Client.Services.CategoryService;
using Final_Exam_Project.Client.Services.ProductService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductServiceClient, ProductServiceClient>();
builder.Services.AddScoped<ICategoryServiceClient, CategoryServiceClient>();
await builder.Build().RunAsync();
