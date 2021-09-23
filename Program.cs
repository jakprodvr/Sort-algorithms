using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        public static int  Burb(int[] data, int begin, int end, int piv)
        {
            while (begin < end)
            {
                if (piv == begin)
                {
                    if (data[piv] >= data[end])
                    {
                        int aux = data[piv];
                        data[piv] = data[end];
                        data[end] = aux;

                        piv = end;
                        begin++;
                    }
                    else end--;
                }
                else  // piv=end
                {
                    if (data[begin] > data[piv] )
                    {
                        int aux = data[piv];
                        data[piv] = data[begin];
                        data[begin] = aux;

                        piv = begin;
                        end--;
                    }
                    else begin++;
                }
            }
            return piv;
        }

        public static void QuickSortMain(int[] data)
        {            

            Quicksort1(data, 0, data.Length - 1);

            Console.WriteLine();
            Console.WriteLine("ordenado");

            foreach (int k in data)
                Console.Write(k + ", ");


        }

        public static void Quicksort1(int[] data, int begin, int end)
        {
            int cond = end - begin;
            if (cond > 0)
            {
                if (cond == 1)
                {
                    if (data[begin] > data[end])
                    {
                        int aux = data[begin];
                        data[begin] = data[end];
                        data[end] = aux;
                    }
                }
                else
                {
                    int i = begin;
                    int j = end;
                    int piv = FindPivote(data, begin, end);                    
                    while (i < j)
                    {
                        if (i == piv || j == piv)
                        {
                            if (i == piv)
                            {
                                if (data[piv] >= data[j])
                                {
                                    int aux = data[piv];
                                    data[piv] = data[j];
                                    data[j] = aux;
                                    i++;
                                    piv = j;
                                }
                                else j--;
                            }
                            else
                            {
                                if (data[piv] < data[i])
                                {
                                    int aux = data[piv];
                                    data[piv] = data[i];
                                    data[i] = aux;
                                    j--;
                                    piv = i;
                                }
                                else i++;
                            }
                        }
                        else
                        {
                            bool switch_values = (data[i] > data[piv] && data[j] <= data[piv]);
                            bool change_i_j = (data[i] <= data[piv] && data[j] > data[piv]);

                            if (switch_values)
                            {
                                int aux = data[i];
                                data[i] = data[j];
                                data[j] = aux;
                            }
                            if (switch_values || change_i_j)
                            {
                                j--;
                                i++;
                            }
                            else
                            {
                                if (data[i] <= data[piv] && data[j] <= data[piv])
                                    i++;
                                else
                                if (data[i] > data[piv] && data[j] > data[piv])
                                    j--;
                            }
                        }                       
                    }
                    Quicksort1(data, begin, piv-1);
                    Quicksort1(data, piv+1, end);
                }                               
            }            
        } 


                    
            public static int FindPivote(int[] data, int begin, int end)
            {
                return (int)(end + begin) / 2;
            }

            public static int[] RanNumber(int count, int max_val)
            {
                int[] res = new int[count];
                Random r = new Random();
                for (int k = 0; k < count; k++) res[k] = r.Next(max_val);

                return res;
            }

            public static bool Isordered(int[] data)
            {
                for(int k = 0; k < data.Length - 1; k++)
                {
                    if(data[k]<data[k+1])   pppp
                }
                return false;
            }


            static void Main(string[] args)
            {

               // int[] test1 = RanNumber(20,20);
                int [] test = { 1,9,8,5,11,2,6};
                int[] test1 = { 1, 9, 8, 5, 11, 2, 6, 5,2,0,22,66,55,59,29,24,25,25,25 };
                //Random rand = new Random();

                /*
                Console.WriteLine("original");
               for(int k=0;k<test.Length;k++)
                Console.Write(test[k]+ ", ");
            */


            // Burb(test, 0, 7, 0);

            QuickSortMain(test1);
           
          

           
            Console.WriteLine();
            Console.WriteLine("!!OK");
            Console.ReadLine();
        }
    }
}

