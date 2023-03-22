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
        string Path = @"/home/runner/Work/Testdir/1.Game/" + Name + ".txt";
        FileStream fs = File.Create(Path);
        fs.Close();
        using (StreamWriter writetext = new StreamWriter(Path))
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
    static public void CreateDeveloper(string Name)
    {
        string Path = @"/home/runner/Work/Testdir/2.Developer/" + Name + ".txt";
        FileStream fs = File.Create(Path);
        fs.Close();
        using (StreamWriter writetext = new StreamWriter(Path))
        {
            string text = Console.ReadLine();
            writetext.WriteLine("Year when company was established: "+text);
            text=Console.ReadLine();
            writetext.WriteLine("Amount of employees:" +text);
            text=Console.ReadLine();
            writetext.WriteLine("Average salary:" +text);
            text=Console.ReadLine();
            writetext.WriteLine("Head of company:" + text);
        }
    }

    public static void Main(string[] args)
    {
        Create();
        //CreateGame("Mort the Chicken");
        Console.WriteLine("---------");
        //CreateGame("Cristian game about stealing burger at 4 am in cube dimension");
        CreateDeveloper("Cristian game company");
    }
}
