using System;
using System.IO;
class Program
{
    public static string dirPath() 
    {
      return Directory.GetCurrentDirectory();
    }
  
    public static string testDirPath()
    {
      return dirPath() + @"/Testdir";
    }
  
    public static void CreateDirIfNone(string neededDir)
    {
      if (!Directory.Exists(neededDir))
      {
          Directory.CreateDirectory(neededDir);
      }
    }
  
    public static void Create()
    {
        CreateDirIfNone(testDirPath());
        CreateDirIfNone(testDirPath() + @"/Game");
        CreateDirIfNone(testDirPath() + @"/Developer");
        CreateDirIfNone(testDirPath() + @"/Publisher");
    }
  
    public static void CreateGame(string Name)
    {
      string Path = testDirPath() + @"/Game" + Name + ".txt";
      FileStream fs=File.Create(Path);
      fs.Close();
      using(StreamWriter writetext = new StreamWriter(Path)){  
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
      Create();
      CreateGame("Mort the Chicken");
    }
}