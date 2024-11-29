global using TrackerExpense.Client.Services.ExpenseService;
using TrackerExpense.Client.Services.ExpenseService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TrackerExpense.Client;
using BlazorExpenseTracker.Client.Services.ExpenseService;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IExpenseService, ExpenseService>();

await builder.Build().RunAsync();
