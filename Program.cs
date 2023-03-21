using System;

namespace gbkontrolnaya
{
    class Program
    {
        string[] ReadArray(){
            return Console.ReadLine().Split();
        }

        void WriteArray(string[] array){
            for(int i = 0; i < array.Length; i++){
                Console.Write(array[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
