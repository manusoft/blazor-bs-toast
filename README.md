![NuGet Version](https://img.shields.io/nuget/v/ManuHub.Blazor.Toast) ![NuGet Downloads](https://img.shields.io/nuget/dt/ManuHub.Blazor.Toast)

# ManuHub.Blazor.Toast

**ManuHub.Blazor.Toast** is a Blazor component for displaying Bootstrap-based toast notifications with customizable types and positions.

## ⚛️ Features
- Fully integrated with Bootstrap toasts
- Supports different toast types (Success, Error, Info, Warning, Default)
- Customizable toast positions (Top-Right, Top-Left, Bottom-Right, Bottom-Left, Center, etc.)
- JavaScript interop for seamless toast display
- Compatible with Blazor Server, WebAssembly (WASM), and Hybrid apps

## 📦 Installation

Install the NuGet package:
```sh
 dotnet add package ManuHub.Blazor.Toast
```

## 🛠 Setup

### 1️⃣ Register the Service
In `Program.cs`, add the toast service:
```csharp
using ManuHub.Blazor.Toast;

builder.Services.AddBlazorToast();
```

### 2️⃣ Include Bootstrap JS
In `wwwroot/index.html` (Blazor WASM) or `Pages/_Host.cshtml` (Blazor Server),
or `App.razor` (Blazor Server), add:
```html
<script src="lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
```

### 3️⃣ Import the Namespace
In `_Imports.razor`, add:
```razor
@using ManuHub.Blazor.Toast
@inject IToastService ToastService
```

### 4️⃣ Add the Toast Component
In `MainLayout.razor`, include the `<Toast/>` component:
```razor
<ToastBS />
```

## 🚀 Usage

### ✅ Show Toast in a Component
In `Home.razor`, use the `ToastService` to trigger notifications:

```razor
@page "/"

<PageTitle>Home</PageTitle>

<h1>Hello, world!</h1>

<button class="btn btn-primary" @onclick="ShowToast">Show Toast</button>
<button class="btn btn-danger" @onclick="ShowSecondToast">Show Error Toast</button>

@code{
    public async Task ShowToast()
    {
        await ToastService.Show(title: "Hello", message: "Sample Notification.", timestamp: "now");
    }

    public async Task ShowSecondToast()
    {
        await ToastService.Show(title: "Error", message: "Something went wrong!", timestamp: "now",
            type: ToastType.Error, position: ToastPosition.TopCenter);
    }
}
```

## 🎨 Customization

### Toast Types
```csharp
ToastType.Default  // Light Toast
ToastType.Success  // Green Success Toast
ToastType.Error    // Red Error Toast
ToastType.Warning  // Yellow Warning Toast
ToastType.Info     // Blue Info Toast
```

### Toast Positions
```csharp
ToastPosition.BottomLeft    // Bottom Left
ToastPosition.BottomRight   // Bottom Right
ToastPosition.BottomCenter  // Bottom Center
ToastPosition.Center        // Center of Screen
ToastPosition.TopLeft       // Top Left
ToastPosition.TopRight      // Top Right
ToastPosition.TopCenter     // Top Center
```

## 📜 License
[MIT License](LICENSE.txt)

## ✨ Contributions
Feel free to submit issues or pull requests to improve the package!

