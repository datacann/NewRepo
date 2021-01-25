using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> x = new MyDictionary<string, string>();
            x.Add("nets", "harden");
            x.Add("nets", "durant");
            x.Add("dallas", "luka");
            x.Ekran();
            x.Count();
        }
    }
}
