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
        Console.WriteLine("1.Write what you want to do:");
        Console.WriteLine("2.CreateGame for creating file about game");
        Console.WriteLine("3.CreateDeveloper for creating file about developer");
        Console.WriteLine("4.CreatePublisher for creating file about publisher");
        Console.WriteLine("5.DeleteGame for deleting file about game");
        Console.WriteLine("6.DeleteGame for deleting file about game");
        Console.WriteLine("7.DeleteGame for deleting file about game");
        Console.WriteLine("8.Exit to exit");
        while(cycle){
          Console.WriteLine();
          Console.Write("Input command:");
          option=Console.ReadLine();
          if (option=="CreateGame" || option=="Creategame"){
            Console.WriteLine("What do you call a file");
            option=Console.ReadLine();
            CreateGame(option);
          }else if (option=="CreateDeveloper" || option=="Createdeveloper"){
            Console.WriteLine("What do you call a file");
            option=Console.ReadLine();
            CreateDeveloper(option);
          }else if (option=="CreatePublisher" || option=="Createpublisher"){
            Console.WriteLine("What do you call a file");
            option=Console.ReadLine();
            CreatePublisher(option);
          }else if (option=="DeleteGame" || option=="Deletegame"){
            Console.WriteLine("What file you want to delete");
            option=Console.ReadLine();
            DeleteGame(option);
          }else if (option=="DeleteDeveloper" || option=="Deletedeveloper"){
            Console.WriteLine("What file you want to delete");
            option=Console.ReadLine();
            DeleteDeveloper(option);
          }else if (option=="DeletePublisher" || option=="Deletepublisher"){
            Console.WriteLine("What file you want to delete");
            option=Console.ReadLine();
            DeletePublisher(option);
          }else if (option=="Exit" ||option=="exit"){
            cycle=false;
            Console.WriteLine("bye bye");
          }
        }
    }
}
