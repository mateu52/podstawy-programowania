// app.Run();
using System;
using System.IO.Compression;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[] { 1,2,3,4,5,6,7,8,9,12};
            for(int i=9; i>=0;i--){
                Console.WriteLine(tab[i]);
            }
            Console.WriteLine("ok");
        }
    }
}
