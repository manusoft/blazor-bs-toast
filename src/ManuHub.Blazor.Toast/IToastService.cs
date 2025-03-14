
namespace ManuHub.Blazor.Toast;

public interface IToastService
{
    ValueTask Show(string title,                   
                   string message,
                   string timestamp = "now",
                   ToastType type = ToastType.Default,
                   ToastPosition position = ToastPosition.BottomRight);
}