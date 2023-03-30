using System;
using System.IO;

class Program
{
    public static string dirPath()  // Return path to program directory
    {
        return Directory.GetCurrentDirectory();
    }
  
    public static string DataDirPath()  // Return path to "Data" directory
    {
        return dirPath() + @"/Data";
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
        CreateDirIfNone(DataDirPath());
        CreateDirIfNone(DataDirPath() + @"/Game");
        CreateDirIfNone(DataDirPath() + @"/Developer");
        CreateDirIfNone(DataDirPath() + @"/Publisher");
    }
  
    public static void CreateGame(string Name)  // Creates file in .../Game
    {
        string Path = DataDirPath() + @"/Game/" + Name + ".txt";
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

    public static void CreateDeveloper(string Name)  // Creates file in .../Developer
    {
        string Path = DataDirPath() + @"/Developer/" + Name + ".txt";
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
            string text;

            Console.Write("Write Year when company was established: ");
            text=Console.ReadLine();
            writetext.WriteLine("Year when company was established: " + text);

            Console.Write("Write amount of employees: ");
            text=Console.ReadLine();
            writetext.WriteLine("Amount of employees: " + text);

            Console.Write("Write average salary: ");
            text=Console.ReadLine();
            writetext.WriteLine("Average salary: " + text);

            Console.Write("Write Location of headquarters: ");
            text=Console.ReadLine();
            writetext.WriteLine("Location of headquarters: " + text);
        }
    }
    public static void DeletePublisher(string Name){
      string Path = testDirPath() + @"/Publisher/" + Name + ".txt";
        if (File.Exists(Path))
        {
            File.Delete(Path);
            Console.WriteLine("File " + Name + ".txt deleted");
            return;
        }else{
          Console.WriteLine("There no such file");
        }
    }

    public static void ReadGame(string GamePath)  // Prints data of given game
    {
      using (StreamReader readtext = new StreamReader(GamePath))
        {
          Console.WriteLine(readtext.ReadLine().Substring(17));
          Console.WriteLine(readtext.ReadLine().Substring(23));
          Console.WriteLine(readtext.ReadLine().Substring(23));
          Console.WriteLine(readtext.ReadLine().Substring(19));
        }
    }

    public static void ReadDeveloper(string DeveloperPath)  // Prints data of given Developer
    {
      using (StreamReader readtext = new StreamReader(DeveloperPath))
        {
          Console.WriteLine(readtext.ReadLine().Substring(34));
          Console.WriteLine(readtext.ReadLine().Substring(21));
          Console.WriteLine(readtext.ReadLine().Substring(16));
          Console.WriteLine(readtext.ReadLine().Substring(17));
        }
    }

    public static void ReadPublisher(string PublisherPath)  // Prints data of given Publisher
    {
      using (StreamReader readtext = new StreamReader(PublisherPath))
        {
          Console.WriteLine(readtext.ReadLine().Substring(34));
          Console.WriteLine(readtext.ReadLine().Substring(21));
          Console.WriteLine(readtext.ReadLine().Substring(16));
          Console.WriteLine(readtext.ReadLine().Substring(26));
        }
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine(dirPath());  // Debug
        Console.WriteLine(DataDirPath());  // Debug
        CreateNeededDirs();
        bool cycle=true;
        string option;
        while(cycle){
          Console.WriteLine("Write what you want to do");
          Console.WriteLine();
        }
    }
}