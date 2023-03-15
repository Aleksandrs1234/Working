using System;
using System.IO;
class Program
{
    static public void Create()
    {
        string dir = @"/home/runner/Work/Testdir";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        //
        dir = @"/home/runner/Work/Testdir/1.Game";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        //
        dir = @"/home/runner/Work/Testdir/2.Developer";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        //
        dir = @"/home/runner/Work/Testdir/3.Publisher";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
    }
    static public void CreateGame(string Name)
    {
      string Path=@"/home/runner/Work/Testdir/1.Game/"+Name+".txt";
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
        Create();
        CreateGame("Mort the Chicken");
    }
}
