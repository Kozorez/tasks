using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Tree
    {
        int index;
        public Tree(int i)
        {
            index = i;
        }
        public void Tree_Build(int[,] matrix)
        {
            List<int> non_used = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> used = new List<int> { };
            int n = non_used.Count;
            int sum = 0;
            non_used.Remove(index);
            used.Add(index);
            for (int i = 0; i < n - 1; i++)
            {
                int min = int.MaxValue;
                int rem1 = 0;
                int rem2 = 0;
                for (int j = 0; j < used.Count; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (matrix[used[j] - 1, k] < min && matrix[used[j] - 1, k] != 0 && non_used.Contains(k + 1))
                        {
                            min = matrix[used[j] - 1, k];
                            rem1 = used[j];
                            rem2 = k + 1;
                        }
                    }
                }
                Console.WriteLine(rem1 + " -> " + rem2 + " со стоимостью " + min);
                sum += min;
                non_used.Remove(rem2);
                used.Add(rem2);
            }
            Console.WriteLine();
            Console.WriteLine("Итоговая стоимость минимального остовного дерева: " + sum);
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 10]
            {
                {0, 0, 5, 6, 0, 7, 5, 0, 8, 7},
                {0, 0, 0, 2, 3, 0, 2, 3, 2, 3},
                {5, 0, 0, 3, 7, 4, 0, 5, 0, 4},
                {6, 2, 3, 0, 0, 0, 0, 1, 3, 4},
                {0, 3, 7, 0, 0, 3, 2, 5, 2, 0},
                {7, 0, 4, 0, 3, 0, 2, 3, 1, 0},
                {5, 2, 0, 0, 2, 2, 0, 0, 1, 1},
                {0, 3, 5, 1, 5, 3, 0, 0, 0, 0},
                {8, 2, 0, 3, 2, 1, 1, 0, 0, 1},
                {7, 3, 4, 4, 0, 0, 1, 0, 1, 0},
            };

            Tree node_1 = new Tree(1);
            Tree node_2 = new Tree(2);
            Tree node_3 = new Tree(3);
            Tree node_4 = new Tree(4);
            Tree node_5 = new Tree(5);
            Tree node_6 = new Tree(6);
            Tree node_7 = new Tree(7);
            Tree node_8 = new Tree(8);
            Tree node_9 = new Tree(9);
            Tree node_10 = new Tree(10);

            node_1.Tree_Build(matrix);

            Console.ReadKey();
        }
    }
}