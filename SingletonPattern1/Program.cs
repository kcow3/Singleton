using System;

namespace SingletonPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton!");
            Singleton.GetInstance.SetCounter(211);
            var c1 = Singleton.GetInstance.GetCounter();
            Singleton.GetInstance.Counter2 = 3;
            var c2 = Singleton.GetInstance.Counter2;
        }
    }
}
