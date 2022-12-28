using System;

namespace lab4ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n
            m, respectiv m,n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la
            tastaura. Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I
            rezultatul. */

            int i, j;
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrice = new int[n, m];
            int[,] matrice2 = new int[m, n];
            int[,] produsMatrici = new int[n, n];

            for(i=0; i<n; i++)
            {
                for(j=0; j<m; j++)
                {
                    matrice[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    matrice2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            produsMatrici = ProdusMatrici(n, m ,matrice, matrice2);
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(produsMatrici[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] ProdusMatrici(int n, int m,  int[,] matrice, int[,] matrice2)
        {
            int[,] produsMatrice = new int[n, n];
            int a = 0, b = 0;
            for(int k = 0; k <n; k++)
            {
                for(int i = 0; i< n; i++)
                {
                    produsMatrice[k, i] = 0;

                    for(int j = 0; j<m; j++)
                    {
                        produsMatrice[k, i] += matrice[k, j] * matrice2[j, i];
                    }
                }
            }
            return produsMatrice;
        }
    }
}
