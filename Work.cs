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
        dir = @"/home/runner/Work/Testdir/Game";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        //
        dir = @"/home/runner/Work/Testdir/Developer";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        //
        dir = @"/home/runner/Work/Testdir/Publisher";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
    }

    public static void Main(string[] args)
    {
        Create();
    }
}
