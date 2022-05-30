using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weee
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            List<List<int>> mat = new List<List<int>>();
            int copy_c = rand.Next() % 4;
            int copy_r = rand.Next() % 4;
            int N = Math.Max(copy_r, copy_c) + rand.Next() % 5+1;

            Console.WriteLine($"Copy column: {copy_c}, Copy row: {copy_r}");

            List<int> copy_values = new List<int>();
            for (int i = 0; i < N; i++)
                copy_values.Add(rand.Next()%10);

            copy_values[copy_c] = copy_values[copy_r];

            for (int i=0;i<N;i++)
            {
                mat.Add(new List<int>());
                for (int j = 0; j < N; j++)
                {
                    mat[i].Add(rand.Next() % 10);
                    bool copy = false;
                    if (i == copy_r)
                    {
                        mat[i][j] = copy_values[j];
                        copy = true;
                    }
                        
                    if (j == copy_c)
                    {
                        mat[i][j] = copy_values[i];
                        copy = true;
                    }

                    Console.ForegroundColor = copy ? ConsoleColor.Green : ConsoleColor.White;
                    Console.Write(mat[i][j] + " ");
                }
                Console.WriteLine();
            }

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    bool same = true;
                    for (int i = 0; i < N; i++)
                    {

                        if (mat[row][i] != mat[i][col])
                        {
                            same = false;
                            break;
                        }
                    }
                    if (same)
                        Console.WriteLine($"Find same -> row: {row}, column: {col}");
                }
            }
            Console.ReadLine();
        }
    }
}