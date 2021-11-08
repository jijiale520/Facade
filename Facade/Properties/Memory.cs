using System;

namespace Facade.Properties
{
    public class Memory
    {
        public void Start()
        {
            Console.WriteLine("启动Memory");
        }

        public void ShutDown()
        {
            Console.WriteLine("关闭Memory");
        }
    }
}