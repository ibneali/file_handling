using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_handling
{
    class Program
    {
        static void Main(string[] args)
        {
        //    using(FileStream stm = new FileStream("D://ali.txt", FileMode.Create))
        //    {
        //        //using this block no need to close filestream object
        //        stm.WriteByte(70); // this is to write in file of ASCII code of 70 no.
        //    }

            //stm.Write("hi this is create file");


            using (FileStream stm = new FileStream("D://ali.txt", FileMode.Append,FileAccess.Write))
            {
                using (StreamWriter wrt =new StreamWriter(stm))
                {
                    int[] a = { 10, 15, 20, 25, 30, 35 };
                    foreach (var item in a)
                    {
                        wrt.WriteLine(item);
                        
                    }
                    

                    Console.WriteLine("Array File  created Successfully..");  
                }
               
            }
            ;
            Console.ReadLine();

        }
    }
}
