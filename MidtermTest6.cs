using System;

namespace MidtermTest_5
{
    class Program
    {
        static void Stair(int n, char alp)
        {
            for (int z = 1; z <= n; z++)
            {
                int y;
                if (z % 2 != 0)
                    y = z + 1;
                else
                    y = z;

                for (int j = 0; j < y; j++)
                    Console.Write("{0}", alp);
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Char alp;
            alp = char.Parse(Console.ReadLine());
            int n;
            n = int.Parse(Console.ReadLine());

            Stair(n, alp);
        }
    }
}
