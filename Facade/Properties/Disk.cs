using System;

namespace Facade.Properties
{
    public class Disk
    {
        public void Start()
        {
            Console.WriteLine("启动Disk");
        }

        public void ShutDown()
        {
            Console.WriteLine("关闭Disk");
        }
    }
}