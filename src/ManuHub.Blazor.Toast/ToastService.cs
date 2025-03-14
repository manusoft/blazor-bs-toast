using Microsoft.JSInterop;

namespace ManuHub.Blazor.Toast;

internal class ToastService : IAsyncDisposable, IToastService
{
    private readonly Lazy<Task<IJSObjectReference>> moduleTask;

    public ToastService(IJSRuntime jsRuntime)
    {
        moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/ManuHub.Blazor.Toast/toast.js").AsTask());
    }

    public async ValueTask Show(string title = "title",                                
                                string message = "Sample Notification Message",
                                string timestamp = "now",
                                ToastType type = ToastType.Default,
                                ToastPosition position = ToastPosition.BottomRight)
    {
        try
        {
            var module = await moduleTask.Value;

            var bgClass = type switch
            {
                ToastType.Success => "text-bg-success",
                ToastType.Error => "text-bg-danger",
                ToastType.Info => "text-bg-info",
                ToastType.Warning => "text-bg-warning",
                _ => "text-bg-light"
            };

            var positionClass = position switch
            {
                ToastPosition.BottomRight => "bottom-0 end-0",
                ToastPosition.BottomLeft => "bottom-0 start-0",
                ToastPosition.BottomCenter => "bottom-0 start-50 translate-middle-x",
                ToastPosition.Center => "top-50 start-50 translate-middle",
                ToastPosition.TopRight => "top-0 end-0",
                ToastPosition.TopLeft => "top-0 start-0",
                ToastPosition.TopCenter => "top-0 start-50 translate-middle-x",
                _ => "bottom-0 end-0"
            };

            await module.InvokeVoidAsync("showToast", title, message, timestamp, bgClass, positionClass);
        }
        catch (JSException jsEx)
        {
            throw new Exception("JavaScript error when showing toast.", jsEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Unexpected error when showing toast.", ex);
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (moduleTask.IsValueCreated)
        {
            var module = await moduleTask.Value;
            await module.DisposeAsync();
        }
    }
}
