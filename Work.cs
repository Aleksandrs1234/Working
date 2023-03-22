using System;
using System.IO;

class Program
{
    public static string dirPath()  // Return path to program directory
    {
        return Directory.GetCurrentDirectory();
    }
  
    public static string testDirPath()  // Return path to "Testdir" directory
    {
        return dirPath() + @"/Testdir";
    }
  
    public static void CreateDirIfNone(string NeededDir)  // Creates directory if it doesnt exist
    {
        if (!Directory.Exists(NeededDir))
        {
            Directory.CreateDirectory(NeededDir);
        }
    }
  
    public static void CreateNeededDirs()  // Create the main directories
    {
        CreateDirIfNone(testDirPath());
        CreateDirIfNone(testDirPath() + @"/Game");
        CreateDirIfNone(testDirPath() + @"/Developer");
        CreateDirIfNone(testDirPath() + @"/Publisher");
    }
  
    public static void CreateGame(string Name)  // Creates file in .../Game
    {
        string Path = testDirPath() + @"/Game/" + Name + ".txt";
        if (File.Exists(Path))
        {
          Console.WriteLine("File already exist");
          return;
        }
        FileStream fs=File.Create(Path);
        fs.Close();
        using(StreamWriter writetext = new StreamWriter(Path))
        {  
            string text = Console.ReadLine();
            writetext.WriteLine("Year of release: " + text);
            text = Console.ReadLine();
            writetext.WriteLine("Developer of the game: " + text);
            text = Console.ReadLine();
            writetext.WriteLine("Publisher of the game: " + text);
            text = Console.ReadLine();
            writetext.WriteLine("Price of the game: " + text);
        }
    }

    public static void CreateDeveloper(string Name)
    {
        string Path = testDirPath() + @"/Developer/" + Name + ".txt";
        if (File.Exists(Path))
        {
            Console.WriteLine("File already exist");
            return;
        }
        FileStream fs = File.Create(Path);
        fs.Close();
        using (StreamWriter writetext = new StreamWriter(Path))
        {
            string text = Console.ReadLine();
            writetext.WriteLine("Year when company was established: " +text);
            text=Console.ReadLine();
            writetext.WriteLine("Amount of employees: " + text);
            text=Console.ReadLine();
            writetext.WriteLine("Average salary: " + text);
            text=Console.ReadLine();
            writetext.WriteLine("Head of company: " + text);
        }
    }
    public static void CreatePublisher(string Name)
    {
        string Path = testDirPath() + @"/Publisher/" + Name + ".txt";
        FileStream fs = File.Create(Path);
        if (File.Exists(Path))
        {
            Console.WriteLine("File already exist");
            return;
        }
        fs.Close();
        using (StreamWriter writetext = new StreamWriter(Path))
        {
            string text = Console.ReadLine();
            writetext.WriteLine("Year when company was established: " + text);
            text=Console.ReadLine();
            writetext.WriteLine("Amount of employees: " + text);
            text=Console.ReadLine();
            writetext.WriteLine("Average salary: " + text);
            text=Console.ReadLine();
            writetext.WriteLine("Smth:" + text);
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(dirPath());  // Debug
        Console.WriteLine(testDirPath());  // Debug
        CreateNeededDirs();
        //CreateGame("Mort the Chicken");
    }
}
