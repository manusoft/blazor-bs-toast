
namespace ManuHub.Blazor.Toast;

public interface IToast
{
    ValueTask Danger(string title, string message);
    ValueTask Info(string title, string message);
    ValueTask Show(string title, string message);
    ValueTask Success(string title, string message);
    ValueTask Warning(string title, string message);
}