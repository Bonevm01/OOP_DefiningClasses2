using System;
[Version("2.1.0")]
class VersionAttributeDemo
{
    static void Main(string[] args)
    {
        Type type = typeof(VersionAttributeDemo);
        object[] atr = type.GetCustomAttributes(false);
        foreach (VersionAttribute item in atr)
        {
            Console.WriteLine("Current version is {0}.",item.currentVersion);
        }
    }
}
