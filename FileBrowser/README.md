# FileBrowser

A lightweight Windows desktop application for browsing and viewing images within a selected folder. Built with **Windows Forms** on **.NET 10**.

## Features

- **Folder Selection** — Use the Browse button to pick any folder on your system.
- **Recursive Scanning** — Automatically discovers images in the selected folder and all its subfolders.
- **Image Navigation** — Navigate through images using Previous/Next buttons or the Left/Right arrow keys.
- **Quick Jump** — Type an image number in the status bar text box and press Enter to jump directly to it.
- **Status Display** — Shows the current image index, total count, and file name.
- **Zoom Fit** — Images are displayed in Zoom mode, scaling to fit the window while preserving aspect ratio.

## Supported Formats

| Format | Extensions                       | Decoder    |
|--------|----------------------------------|------------|
| JPEG   | `.jpg`, `.jpeg`, `.jfif`, `.jpe` | GDI+       |
| PNG    | `.png`                           | GDI+       |
| BMP    | `.bmp`, `.dib`                   | GDI+       |
| GIF    | `.gif`                           | GDI+       |
| TIFF   | `.tiff`, `.tif`                  | GDI+       |
| ICO    | `.ico`                           | GDI+       |
| WebP   | `.webp`                          | ImageSharp |
| Targa  | `.tga`                           | ImageSharp |
| PBM    | `.pbm`                           | ImageSharp |
| QOI    | `.qoi`                           | ImageSharp |

> **Note:** Most formats are handled natively by GDI+ (`System.Drawing`). WebP, Targa, PBM, and QOI support is provided via [SixLabors.ImageSharp](https://github.com/SixLabors/ImageSharp).

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) (Windows)

## Build and Run

```bash
dotnet build
dotnet run --project FileBrowser
```

## Keyboard Shortcuts

| Key          | Action                              |
|--------------|-------------------------------------|
| Left arrow   | Previous image                      |
| Right arrow  | Next image                          |
| Enter        | Jump to image number (in text box)  |
