using System;
using Facade.Properties;

namespace Facade
{
    internal class Program
    {
        //外观模式
        public static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Start();
            Console.WriteLine("==================");
            computer.ShutDown();
        }
    }
}