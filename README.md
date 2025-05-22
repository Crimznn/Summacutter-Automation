# Summacutter Automation

This repository contains a Windows Forms application for generating print files from image sets.

## Building
1. Install the .NET Framework 4.x SDK or Visual Studio so that `msbuild` is available.
2. Open `PrintFileMaker.sln` in Visual Studio or run `msbuild PrintFileMaker.sln` from the command line.
3. Binaries are produced in the `bin/Debug` or `bin/Release` directories.

Make sure the `PrintFileMaker.exe.config` file remains next to the executable so the application can read its settings.

## Usage
Run `PrintFileMaker.exe`, choose your layout and images, and use **Edit → Preferences** to set default folders.
