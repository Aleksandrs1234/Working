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
            Console.Write("Write year of release:");
            string text = Console.ReadLine();
            writetext.WriteLine("Year of release: " + text);
            Console.Write("Write Developer of the game:");
            text = Console.ReadLine();
            writetext.WriteLine("Developer of the game: " + text);
            Console.Write("Write publisher of the game:");
            text = Console.ReadLine();
            writetext.WriteLine("Publisher of the game: " + text);
            Console.Write("Write Price of the game:");
            text = Console.ReadLine();
            writetext.WriteLine("Price of the game: " + text);
        }
    }
    public static void DeleteGame(string Name){
      string Path = testDirPath() + @"/Game/" + Name + ".txt";
        if (File.Exists(Path))
        {
            File.Delete(Path);
            Console.WriteLine("File "+Name+".txt deleted");
            return;
        }else{
          Console.WriteLine("There no such file");
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
            Console.Write("Write year when company was established:");
            string text = Console.ReadLine();
            writetext.WriteLine("Year when company was established: " +text);
            Console.Write("Write amount of employees:");
            text=Console.ReadLine();
            writetext.WriteLine("Amount of employees: " + text);
            Console.Write("Write average salary:");
            text=Console.ReadLine();
            writetext.WriteLine("Average salary: " + text);
            Console.Write("Write head of company:");
            text=Console.ReadLine();
            writetext.WriteLine("Head of company: " + text);
        }
    }
    public static void DeleteDeveloper(string Name){
      string Path = testDirPath() + @"/Developer/" + Name + ".txt";
        if (File.Exists(Path))
        {
            File.Delete(Path);
            Console.WriteLine("File "+Name+".txt deleted");
            return;
        }else{
          Console.WriteLine("There no such file");
        }
    }
    public static void CreatePublisher(string Name)
    {
        string Path = testDirPath() + @"/Publisher/" + Name + ".txt";
  
        if (File.Exists(Path))
        {
            Console.WriteLine("File already exist");
            return;
        }
        FileStream fs = File.Create(Path);
        fs.Close();
        using (StreamWriter writetext = new StreamWriter(Path))
        {
            Console.Write("Write Year when company was established:");
            string text = Console.ReadLine();
            writetext.WriteLine("Year when company was established: " + text);
            Console.Write("Write amount of employees:");
            text=Console.ReadLine();
            writetext.WriteLine("Amount of employees: " + text);
            Console.Write("Write average salary:");
            text=Console.ReadLine();
            writetext.WriteLine("Average salary: " + text);
            Console.Write("Write Location of headquarters:");
            text=Console.ReadLine();
            writetext.WriteLine("Location of headquartres:" + text);
        }
    }
    public static void DeletePublisher(string Name){
      string Path = testDirPath() + @"/Publisher/" + Name + ".txt";
        if (File.Exists(Path))
        {
            File.Delete(Path);
            Console.WriteLine("File "+Name+".txt deleted");
            return;
        }else{
          Console.WriteLine("There no such file");
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(dirPath());  // Debug
        Console.WriteLine(testDirPath());  // Debug
        CreateNeededDirs();
        bool cycle=true;
        string option;
        while(cycle){
          Console.WriteLine("Write what you want to do");
          Console.WriteLine();
        }
    }
}
