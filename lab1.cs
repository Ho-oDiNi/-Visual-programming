using System;

namespace ConsoleApp1
{
    class Program
    {
        public class HW1
        {
            public static long QueueTime(int[] customers, int n)
            {
                int[] B = new int[n];
                int k = n;
                long time = 0;
                int flag = customers.Length;
                bool check_end = true;
                for (int i = 0; i < n; i++)
                {
                    B[i] = i;
                }
                
                while(check_end)
                {
                    time++;
                    for (int i = 0; i < n; i++)
                    {
                        if (customers[B[i]] != 0)
                        {
                            customers[B[i]]--;
                        }

                        if (customers[B[i]] == 0)
                        {
                            if (k != flag)
                            {
                                B[i] = k;
                                k++;
                            }
                        }
                        check_end = false;
                        for (int j = 0; j < flag; j++)
                        {
                            if (customers[j] != 0)
                                check_end = true;
                        }
                    }
                }


                return time;
            }
        }

        static void Main(string[] args)
        {
            long time = 0;
            int[] A = new int[3];
            A[0] = 5;
            A[1] = 3;
            A[2] = 4;
            time = HW1.QueueTime(A, 1);
            Console.WriteLine(time);

            int[] B = new int[4];
            B[0] = 10;
            B[1] = 2;
            B[2] = 3;
            B[3] = 3;

            time = HW1.QueueTime(B, 2);
            Console.WriteLine(time);
            
            int[] C = new int[3];
            C[0] = 2;
            C[1] = 3;
            C[2] = 10;

            
            time = HW1.QueueTime(C, 2);
            Console.WriteLine(time);

        }
    }
}
