using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAssignment200824
{
    
   
   
    internal class tempClass
    {
       
        public void show()
        {
            
            int[] x = { 5, 3, 1, 2,1,2 };//1  1  2   2  3  5
            
           
            //sort logic

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i+1; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        int temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                    }
                }
            }
            Console.WriteLine("sorted array...");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("\t" + x[i]);
            }
            //-------------------------------------------------------------------------
            int[] b = new int[x.Length];
            int k = 0;//b[k++]
            for (int i = 0; i < x.Length;)
            {
                int cnt = 1;//count reperation
                for (int j = i+1; j < x.Length; j++)
                {
                    if (x[i] == x[j])
                    {
                        cnt++;
                    }
                    else
                    {
                        break;
                    }
                }
                b[k++] = x[i];
                i = i + cnt;
            }
            Console.WriteLine("-- array b=");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
