namespace ManuHub.Blazor.Toast;

public class ToastOptions
{
    /// <summary>
    /// Maximum number of toasts shown concurrently. Null means unlimited.
    /// </summary>
    public int? MaxToasts { get; set; } = null;

    /// <summary>
    /// Default toast position.
    /// </summary>
    public ToastPosition Position { get; set; } = ToastPosition.BottomRight;

    /// <summary>
    /// Default toast style.
    /// </summary>
    public ToastStyle ToastStyle { get; set; } = ToastStyle.Custom;
}
