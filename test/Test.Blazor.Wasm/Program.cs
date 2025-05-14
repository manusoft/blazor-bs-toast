using ManuHub.Blazor.Toast;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Test.Blazor.Wasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazorToast(options =>
{
    //options.MaxToasts = 5;
    options.ToastStyle = ToastStyle.Default;
    options.Position = ToastPosition.BottomRight;
    options.ShowCloseButton = true;
    options.IncludeCDN = true; // Automatically includes the CDN for Bootstrap and Tailwind CSS stylesheets and JS.
});

await builder.Build().RunAsync();
