using System;
using System.Threading;

namespace Facade.Properties
{
    public class Computer
    {
        private CPU cpu;
        private Memory memory;
        private Disk disk;

        public Computer()
        {
            cpu = new CPU();
            memory = new Memory();
            disk = new Disk();
        }

        public void Start()
        {
            Console.WriteLine("电脑开始启动");
            cpu.Start();
            memory.Start();
            disk.Start();
            Console.WriteLine("电脑已经启动");
        }

        public void ShutDown()
        {
            Console.WriteLine("电脑开始关机");
            disk.ShutDown();
            memory.ShutDown();
            cpu.ShutDown();
            Console.WriteLine("电脑已经关机");
        }
    }
}