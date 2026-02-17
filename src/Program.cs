using System.Diagnostics;

var processInfo = new ProcessStartInfo
{
    FileName = "dotnet",
    Arguments = string.Join(' ', ["run", ..args]),
    UseShellExecute = false,
};

Console.WriteLine($"Running: {processInfo.FileName} {processInfo.Arguments}");

await Process.Start(processInfo)!.WaitForExitAsync();