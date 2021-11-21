using EasyLogger;
using System;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Guid());
            Log.V("Verbose");
            Log.I("Informational");
            Log.W("Warning");
            Log.E("Error");
            Log.C("Critical");
        }
    }
}
