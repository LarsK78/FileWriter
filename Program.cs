using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, "randomFile.bin");

        const int fileSizeInBytes = 50 * 1024 * 1024; // 10 MB
        byte[] buffer = new byte[fileSizeInBytes];
        Random random = new Random();

        try
        {
            while (true)
            {
                // Fülle den Buffer mit zufälligen Werten
                random.NextBytes(buffer);

                // Erstelle die Datei mit den zufälligen Werten
                File.WriteAllBytes(filePath, buffer);

                // Gebe "ok file" auf der Konsole aus
                Console.WriteLine("ok file");

                // Warte eine Sekunde
                System.Threading.Thread.Sleep(5000);

                // Lösche die Datei
                File.Delete(filePath);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
        }
    }
}
