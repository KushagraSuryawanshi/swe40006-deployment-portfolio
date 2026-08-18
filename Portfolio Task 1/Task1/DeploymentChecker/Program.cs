using System;
using Spectre.Console;
using Humanizer;

namespace DeploymentChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Deployment folder path:");
            string? userInput = Console.ReadLine();
            userInput = userInput?.Trim().Trim('"');


            if (string.IsNullOrWhiteSpace(userInput) || !Directory.Exists(userInput))
            {
                Console.WriteLine("Directory does not exist");
            }
            else
            {
                AnsiConsole.MarkupLine("[green]Directory found[/]");

                string[] allFiles = Directory.GetFiles(userInput);
                long totalSize = 0;

                bool hasExe = false;
                int dllCount = 0;
                bool hasDepsJson = false;
                bool hasRuntimeConfigJson = false;

                foreach (string file in allFiles)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    totalSize += fileInfo.Length;

                    string fileName = Path.GetFileName(file);
                    string extension = Path.GetExtension(file);

                    if (extension.Equals(".exe", StringComparison.OrdinalIgnoreCase))
                        hasExe = true;

                    if (extension.Equals(".dll", StringComparison.OrdinalIgnoreCase))
                        dllCount++;

                    if (fileName.EndsWith(".deps.json", StringComparison.OrdinalIgnoreCase))
                        hasDepsJson = true;

                    if (fileName.EndsWith(".runtimeconfig.json", StringComparison.OrdinalIgnoreCase))
                        hasRuntimeConfigJson = true;
                }

                var table = new Table();

                table.AddColumn("Check");
                table.AddColumn("Result");

                table.AddRow("File count",
                    $"{allFiles.Length} ({allFiles.Length.ToWords()})");
                table.AddRow("Total size", $"{totalSize} bytes");
                table.AddRow("EXE found", hasExe.ToString());
                table.AddRow("DLL count", dllCount.ToString());
                table.AddRow(".deps.json", hasDepsJson.ToString());
                table.AddRow(".runtimeconfig.json", hasRuntimeConfigJson.ToString());

                AnsiConsole.Write(table);

                bool isValid =
                    hasExe &&
                    dllCount >= 2 &&
                    hasDepsJson &&
                    hasRuntimeConfigJson;

                if (isValid)
                {
                    AnsiConsole.MarkupLine(
                        "[green]Deployment package looks valid[/]");
                }
                else
                {
                    AnsiConsole.MarkupLine(
                        "[red]Deployment package looks incomplete.[/]");
                }
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}