using System;

namespace DictionaryHomework
{
    internal class Program
    {
        static void Main(string[] args) {
            MyDictionary <int, string> idAndNames = new MyDictionary<int,string> ();

            idAndNames.Add(1, "Kübra");
            idAndNames.Add(2, "Merve");
            idAndNames.Add(3, "Necati");
            idAndNames.Add(4, "Can");

        }
    }
}