using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паук_и_муха
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double Res=0;
            string a = Console.ReadLine();
            string[] A = a.Split(new char[] { ' ' });
            int[] A1 = new int[A.Length];
            for (int i=0;i<A.Length; i++)
            {
                A1[i] = Convert.ToInt32(A[i]);
            }
            string b = Console.ReadLine();
            string[] B = b.Split(new char[] { ' ' });
            int[] B1 = new int[B.Length];
            for (int i = 0; i < B.Length; i++)
            {
                B1[i] = Convert.ToInt32(B[i]);
            }
            string c = Console.ReadLine();
            string[] C = c.Split(new char[] { ' ' });
            int[] C1 = new int[C.Length];
            for (int i = 0; i < C.Length; i++)
            {
                C1[i] = Convert.ToInt32(C[i]);
            }
            if (((B1[0] == C1[0]) && ((B1[0] == 0) || (B1[0] == A1[0]))) || ((B1[1] == C1[1]) && ((B1[1] == 0) || (B1[1] == A1[1]))) || ((B1[2] == C1[2]) && ((B1[2] == 0) || (B1[2] == A1[0]))))
            {
                Res = Math.Pow(Math.Pow(Math.Abs(B1[0] - C1[0]), 2) + Math.Pow(Math.Abs(B1[1] - C1[1]), 2) + Math.Pow(Math.Abs(B1[2] - C1[2]), 2), 0.5);
            }
            else if ((Math.Abs(B1[0] - C1[0]) == A1[0]) || (Math.Abs(B1[1] - C1[1]) == A1[1]) || (Math.Abs(B1[2] - C1[2]) == A1[2]))
            {
                if (Math.Abs(B1[0] - C1[0]) == A1[0])
                {
                    Res = Math.Min(Math.Pow(Math.Pow(Math.Abs(C1[1] - B1[1]), 2)
                        + Math.Pow((Math.Min(C1[2] + B1[2], 2 * A1[2] - C1[2] - B1[2]) + A1[0]), 2), 0.5),
                        Math.Pow(Math.Pow(Math.Min(C1[1] + B1[1], 2 * A1[1] - C1[1] - B1[1]) + A1[0], 2)
                        + Math.Pow((Math.Abs(C1[2] - B1[2])), 2), 0.5));
                }
                else if (Math.Abs(B1[1] - C1[1]) == A1[1])
                {
                    Res = Math.Min(Math.Pow(Math.Pow(Math.Abs(C1[0] - B1[0]), 2)
                        + Math.Pow((Math.Min(C1[2] + B1[2], 2 * A1[2] - C1[2] - B1[2]) + A1[1]), 2), 0.5),
                        Math.Pow(Math.Pow(Math.Min(C1[0] + B1[0], 2 * A1[0] - C1[0] - B1[0]) + A1[1], 2)
                        + Math.Pow((Math.Abs(C1[2] - B1[2])), 2), 0.5));
                }
                else if (Math.Abs(B1[2] - C1[2]) == A1[2])
                {
                    Res = Math.Min(Math.Pow(Math.Pow(Math.Abs(C1[1] - B1[1]), 2)
                        + Math.Pow((Math.Min(C1[0] + B1[0], 2 * A1[0] - C1[0] - B1[0]) + A1[2]), 2), 0.5),
                        Math.Pow(Math.Pow(Math.Min(C1[1] + B1[1], 2 * A1[1] - C1[1] - B1[1]) + A1[2], 2)
                        + Math.Pow((Math.Abs(C1[0] - B1[0])), 2), 0.5));
                }
            }
            else
            {
                if (B1[0] == 0)
                {
                    if ((C1[1] == 0) || (C1[1] == A1[1]))
                    {
                        Res = Math.Pow(Math.Pow(Math.Abs(B1[1] - C1[1]) + C1[0], 2) + Math.Pow(Math.Abs(B1[2] - C1[2]), 2), 0.5);
                    }
                    else
                    {
                        Res = Math.Pow(Math.Pow(Math.Abs(B1[1] - C1[1]), 2) + Math.Pow(Math.Abs(B1[2] - C1[2]) + C1[0], 2), 0.5);
                    }
                }
                else if (B1[0] == A1[0])
                {
                    if ((C1[1] == 0) || (C1[1] == A1[1]))
                    {
                        Res = Math.Pow(Math.Pow(Math.Abs(B1[1] - C1[1]) + A1[0] - C1[0], 2) + Math.Pow(Math.Abs(B1[2] - C1[2]), 2), 0.5);
                    }
                    else
                    {
                        Res = Math.Pow(Math.Pow(Math.Abs(B1[1] - C1[1]), 2) + Math.Pow(Math.Abs(B1[2] - C1[2]) + A1[0] - C1[0], 2), 0.5);
                    }
                }
                else if (B1[1] == 0)
                {
                    if ((C1[0] == 0) || (C1[0] == A1[0]))
                    {
                        Res = Math.Pow(Math.Pow(Math.Abs(B1[0] - C1[0]) + C1[1], 2) + Math.Pow(Math.Abs(B1[2] - C1[2]), 2), 0.5);
                    }
                    else
                    {
                        Res = Math.Pow(Math.Pow(Math.Abs(B1[0] - C1[0]), 2) + Math.Pow(Math.Abs(B1[2] - C1[2]) + C1[1], 2), 0.5);
                    }
                }
                else if (B1[1] == A1[1])
                {
                    if ((C1[0] == 0) || (C1[0] == A1[0]))
                    {
                        Res = Math.Pow(Math.Pow(Math.Abs(B1[0] - C1[0]) + A1[1] - C1[1], 2) + Math.Pow(Math.Abs(B1[2] - C1[2]), 2), 0.5);
                    }
                    else
                    {
                        Res = Math.Pow(Math.Pow(Math.Abs(B1[0] - C1[0]), 2) + Math.Pow(Math.Abs(B1[2] - C1[2]) + A1[1] - C1[1], 2), 0.5);
                    }

                }
                else if (B1[2] == 0)
                {
                    if ((C1[0] == 0) || (C1[0] == A1[0]))
                    {
                        Res = Math.Pow(Math.Pow(Math.Abs(B1[0] - C1[0]) + C1[2], 2) + Math.Pow(Math.Abs(B1[1] - C1[1]), 2), 0.5);
                    }
                    else
                    {
                        Res = Math.Pow(Math.Pow(Math.Abs(B1[0] - C1[0]), 2) + Math.Pow(Math.Abs(B1[1] - C1[1]) + C1[2], 2), 0.5);
                    }
                }
                else if (B1[2] == A1[2])
                {
                    if ((C1[0] == 0) || (C1[0] == A1[0]))
                    {
                        Res = Math.Pow(Math.Pow(Math.Abs(B1[0] - C1[0]) + A1[2] - C1[2], 2) + Math.Pow(Math.Abs(B1[1] - C1[1]), 2), 0.5);
                    }
                    else
                    {
                        Res = Math.Pow(Math.Pow(Math.Abs(B1[0] - C1[0]), 2) + Math.Pow(Math.Abs(B1[1] - C1[1]) + A1[2] - C1[2], 2), 0.5);
                    }

                }
            }
            Console.WriteLine(Res);

        }
    }
}
