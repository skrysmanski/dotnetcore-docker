using System;
using Newtonsoft.Json;

namespace DockerCoreConsoleTest
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(
                $"Hello, Docker and {typeof(JsonConvert).FullName}!"
            );
        }
    }
}
