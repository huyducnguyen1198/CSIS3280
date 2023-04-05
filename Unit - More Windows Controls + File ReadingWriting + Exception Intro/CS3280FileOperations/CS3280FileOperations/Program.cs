using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3280FileOperations
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            var asyncF = Task.Run(()=> doAsync());
            await asyncF;
            for (int i = 0; i < 1000; i++)
            {
                if (asyncF.Status == TaskStatus.RanToCompletion)
                {
                    Console.WriteLine("                 Done");
                    break;

                }
                else
                {
                    Console.WriteLine("             out: " + asyncF.Status);
                }
            }




            Console.ReadLine();
        }
        static  async Task<String> doAsync()
        {
            Console.WriteLine("Async start");
            int a = 0;
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine("         async: " + i);
                
            }
            Console.WriteLine("Async End");
            return "Hello World async";
        }
        public static String doSync()
        {
            for(int i = 0;i < 1000; i++)
            {
                Console.WriteLine("sync: "+i);
            }
            return "Hello World";
        }
    }

}
