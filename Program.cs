// app.Run();
using System;
using System.IO.Compression;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oceny = new int[] {1, 3,3, 0, 2, 5};
            int n = oceny.Length;
            int max = oceny[0];
            for(int i=0;i<n;i++){
                if(oceny[i]>max){
                    max = oceny[i];
                }
            }
            for(int i = 0; i<n; i++){
                for(int j=0; j< n -i-1;j++){
                    if(oceny[j]>oceny[j+1]){
                        int temp = oceny[j];
                        oceny[j] = oceny[j+1];
                        oceny[j+1] = temp;
                    }
                }
            }
            foreach(int i in oceny){
                Console.WriteLine(i);
            }
            Console.WriteLine("max:"+ max);
        }
    }
}
