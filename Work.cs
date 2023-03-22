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
      FileStream fs=File.Create(Path);
      fs.Close();
      using(StreamWriter writetext = new StreamWriter(Path))
      {  
        writetext.WriteLine("First");
        writetext.WriteLine("Second");
        writetext.WriteLine("Third");
        writetext.WriteLine("Fourth");
      }
    }

    public static void Main(string[] args)
    {
      Console.WriteLine(dirPath());
      Console.WriteLine(testDirPath());
      CreateNeededDirs();
      CreateGame("Mort the Chicken");
    }
}
