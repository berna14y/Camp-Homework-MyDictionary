using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<string, string> mydict = new MyDict<string, string>();
            mydict.Add("UK", "London, Manchester, Birmingham");
            mydict.Add("USA", "Chicago, New York, Washington");
            mydict.Add("India", "Mumbai, New Delhi, Pune");
        }
    }
}
