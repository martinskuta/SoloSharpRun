# SoloSharpRun
Lightweight Windows tool that lets you execute C# source files directly by invoking the .NET file-based execution feature (e.g., dotnet run file.cs). When registered as the default application for .cs files in Windows, it intercepts file launches and runs dotnet run &lt;file> under the hood, giving you a script-like experience for C#.
