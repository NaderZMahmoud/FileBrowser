# FileBrowser

A lightweight Windows desktop application for browsing and viewing images within a selected folder. Built with **Windows Forms** on **.NET 10**.

## Features

- **Folder Selection** — Use the Browse button to pick any folder on your system.
- **Recursive Scanning** — Automatically discovers images in the selected folder and all its subfolders.
- **Image Navigation** — Navigate through images using Previous/Next buttons or the Left/Right arrow keys.
- **Status Display** — Shows the current image index, total count, and file name.
- **Zoom Fit** — Images are displayed in Zoom mode, scaling to fit the window while preserving aspect ratio.

## Supported Formats

| Format | Extensions          |
|--------|---------------------|
| JPEG   | `.jpg`, `.jpeg`, `.jfif` |
| PNG    | `.png`              |
| BMP    | `.bmp`              |
| GIF    | `.gif`              |
| TIFF   | `.tiff`, `.tif`     |
| ICO    | `.ico`              |

> **Note:** These are the formats natively supported by GDI+ (`System.Drawing`). WebP and other modern formats are not supported.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) (Windows)

## Build & Run

```bash
dotnet build
dotnet run --project FileBrowser
```

## Keyboard Shortcuts

| Key          | Action         |
|--------------|----------------|
| `←` Left     | Previous image |
| `→` Right    | Next image     |
