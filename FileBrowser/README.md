# FileBrowser

A lightweight Windows desktop application for browsing images and videos. Built with **Windows Forms** on **.NET 10**.

The application opens with a **Main Form** that lets you launch dedicated browsers for images or videos.

## Application Structure

| Form | Purpose |
|------|---------|
| **MainForm** | Launcher with buttons to open the Images or Videos browser |
| **ImagesForm** | Browse and view images from a selected folder |
| **VideosForm** | Browse and play videos from a selected folder |

## Features

### Main Form

- Central launcher for the application.
- **Browse Images** button — opens the image browser.
- **Browse Videos** button — opens the video browser.
- Multiple browser windows can be open at the same time.

### Images Browser

- **Folder Selection** — Use the Browse button to pick any folder on your system.
- **Recursive Scanning** — Automatically discovers images in the selected folder and all its subfolders.
- **Image Navigation** — Navigate through images using Previous/Next buttons or the Left/Right arrow keys.
- **Quick Jump** — Type an image number in the status bar text box and press Enter to jump directly to it.
- **Status Display** — Shows the current image index, total count, and file name.
- **Zoom Fit** — Images are displayed in Zoom mode, scaling to fit the window while preserving aspect ratio.

### Videos Browser

- **Folder Selection** — Use the Browse button to pick any folder on your system.
- **Recursive Scanning** — Automatically discovers videos in the selected folder and all its subfolders.
- **Split View** — Video list on the left, built-in player on the right.
- **Internal Player** — Play videos directly inside the application using [LibVLCSharp](https://github.com/videolan/libvlcsharp).
- **Playback Controls** — Play/Pause, Stop, seek bar, time display, and volume slider.
- **Video Navigation** — Navigate through the list using Previous/Next buttons or the Left/Right arrow keys.
- **Double-Click to Play** — Double-click any video in the list to start playback.
- **Status Display** — Shows the current video index, total count, and file name.

## Supported Formats

### Image Formats

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

> **Note:** Most image formats are handled natively by GDI+ (`System.Drawing`). WebP, Targa, PBM, and QOI support is provided via [SixLabors.ImageSharp](https://github.com/SixLabors/ImageSharp).

### Video Formats

| Format | Extensions     |
|--------|----------------|
| MP4    | `.mp4`         |
| AVI    | `.avi`         |
| MKV    | `.mkv`         |
| MOV    | `.mov`         |
| WMV    | `.wmv`         |
| FLV    | `.flv`         |
| WebM   | `.webm`        |
| M4V    | `.m4v`         |
| MPEG   | `.mpg`, `.mpeg`|

> **Note:** Video playback is powered by [LibVLCSharp](https://github.com/videolan/libvlcsharp) with bundled LibVLC native libraries — no external software is required.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) (Windows)

## Build and Run

```bash
dotnet build
dotnet run --project FileBrowser
```

## Keyboard Shortcuts

### Images Browser

| Key          | Action                              |
|--------------|-------------------------------------|
| Left arrow   | Previous image                      |
| Right arrow  | Next image                          |
| Enter        | Jump to image number (in text box)  |

### Videos Browser

| Key          | Action                                   |
|--------------|------------------------------------------|
| Left arrow   | Previous video                           |
| Right arrow  | Next video                               |
| Space        | Play / Pause                             |
| Double-click | Play selected video in internal player   |
