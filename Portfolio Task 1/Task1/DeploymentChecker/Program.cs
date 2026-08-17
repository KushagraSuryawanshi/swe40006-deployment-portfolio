using System;
namespace DeploymentChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Deployment folder path:");
            string? userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput) || !Directory.Exists(userInput)) {
                Console.WriteLine("Directory does not exist");
            }
            else
            {
                Console.WriteLine("Directory found");
                string[] allFiles = Directory.GetFiles(userInput);
                long totalSize = 0;

                Console.WriteLine($"File count: {allFiles.Length}");

                bool hasExe = false;
                bool hasDll = false;
                bool hasJson = false;

                foreach (string file in allFiles)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    totalSize += fileInfo.Length;

                    Console.WriteLine(Path.GetFileName(file));

                    string extension = Path.GetExtension(file);

                    if (extension == ".exe") 
                    {
                        hasExe = true;
                    }
                    if (extension == ".dll") 
                    {
                        hasDll = true;
                    }
                    if (extension == ".json")
                    {
                        hasJson = true;
                    }
                
                }

                Console.WriteLine($"Total size: {totalSize} bytes");
                Console.WriteLine($"EXE found: {hasExe}");
                Console.WriteLine($"DLL found: {hasDll}");
                Console.WriteLine($"JSON found: {hasJson}");

                if (hasExe && hasDll && hasJson)
                {
                    Console.WriteLine("Deployment package looks valid.");
                }
                else
                {
                    Console.WriteLine("Deployment package looks incomplete.");
                }
            }

           
        }
    }
}