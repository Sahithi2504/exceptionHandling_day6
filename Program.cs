using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 25;
            int j = 5;
            //int result = i / j;
            try
            {
                int result = i / j;
                Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Divide by 0 is not allowed");

            }
            finally
            {
                Console.WriteLine("End");
            }
            Console.ReadLine();
        }


        //-----------index out of bound-------
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        int[] arr = new int[5];
        //        arr[10] = 25;
        //    }
        //    catch (SystemException e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //    Console.ReadLine();
        //}
    }
}
  
    
    
