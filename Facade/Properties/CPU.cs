using System;

namespace Facade.Properties
{
    public class CPU
    {
        public void Start()
        {
            Console.WriteLine("启动CPU");
        }

        public void ShutDown()
        {
            Console.WriteLine("关闭CPU");
        }
    }
}