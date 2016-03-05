using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_Algorithm
{
    class Graph
    {
        int index;
        int label;
        string optimal_path;

        public Graph(int i)
        {
            index = i;
            label = int.MaxValue;
        }

        public static int Get_Smallest_Label(List<Graph> nodes, List<Graph> non_used)
        {
            int min = non_used[0].index;
            for (int i = 1; i < non_used.Count; i++)
            {
                if (non_used[i].label < nodes[min - 1].label)
                {
                    min = non_used[i].index;
                }
            }
            return min;
        }

        public void Dijkstra(List<Graph> nodes, int[,] matrix)
        {
            List<Graph> non_used = new List<Graph> { };
            List<Graph> used = new List<Graph> { };
            foreach (Graph node in nodes)
            {
                non_used.Add(node);
            }
            int n = nodes.Count;
            label = 0;
            for (int i = 0; i < n; i++)
            {
                Graph temp = nodes[Get_Smallest_Label(nodes, non_used) - 1];
                non_used.Remove(temp);
                used.Add(temp);
                foreach (Graph node in non_used)
                {
                    if (matrix[temp.index - 1, node.index - 1] != 0 && 
                        node.label > temp.label + matrix[temp.index - 1, node.index - 1])
                    {
                        node.label = temp.label + matrix[temp.index - 1, node.index - 1];
                        node.optimal_path = temp.optimal_path + temp.index + " -> ";
                    }
                }
                temp.optimal_path += temp.index;
            }
            foreach (Graph node in nodes)
            {
                Console.WriteLine("A shortest distance frow node with index {0} to the node with index {1} = {2}", index, node.index, node.label);
            }
            Console.WriteLine();
            foreach (Graph node in nodes)
            {
                Console.WriteLine("A shortest path frow node with index {0} to the node with index {1} = {2}", index, node.index, node.optimal_path);
            }
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[12, 12]
            {
                {0, 17, 13, 12, 11, 0, 12, 17, 8, 15, 0, 13},
                {17, 0, 8, 7, 5, 2, 6, 1, 10, 2, 1, 6},
                {13, 8, 0, 4, 3, 0, 3, 7, 1, 5, 8, 5},
                {12, 7, 4, 0, 4, 9, 1, 7, 2, 5, 7, 2},
                {11, 5, 3, 4, 0, 8, 3, 0, 5, 4, 6, 2},
                {0, 2, 0, 9, 8, 0, 8, 3, 0, 6, 3, 7},
                {12, 6, 3, 1, 3, 8, 0, 7, 2, 4, 7, 3},
                {17, 1, 7, 7, 0, 3, 7, 0, 8, 2, 3, 4},
                {8, 10, 1, 2, 5, 0, 2, 8, 0, 6, 0, 5},
                {15, 2, 5, 5, 4, 6, 4, 2, 6, 0, 4, 1},
                {0, 1, 8, 7, 6, 3, 7, 3, 0, 4, 0, 6},
                {13, 6, 5, 2, 2, 7, 3, 4, 5, 1, 6, 0},
            };

            Graph node_1 = new Graph(1);
            Graph node_2 = new Graph(2);
            Graph node_3 = new Graph(3);
            Graph node_4 = new Graph(4);
            Graph node_5 = new Graph(5);
            Graph node_6 = new Graph(6);
            Graph node_7 = new Graph(7);
            Graph node_8 = new Graph(8);
            Graph node_9 = new Graph(9);
            Graph node_10 = new Graph(10);
            Graph node_11 = new Graph(11);
            Graph node_12 = new Graph(12);

            List<Graph> nodes = new List<Graph> { node_1, node_2, node_3, node_4, node_5, node_6, node_7, node_8, node_9, node_10, node_11, node_12 };

            node_1.Dijkstra(nodes, matrix);

            //int[,] matrix = new int[4, 4]
            //{
            //    {0, 4, 5, 0},
            //    {4, 0, 1, 3},
            //    {5, 1, 0, 2},
            //    {0, 3, 2, 0},
            //};

            //Graph node_1 = new Graph(1);
            //Graph node_2 = new Graph(2);
            //Graph node_3 = new Graph(3);
            //Graph node_4 = new Graph(4);

            //List<Graph> nodes = new List<Graph> { node_1, node_2, node_3, node_4 };

            //node_1.Dijkstra(nodes, matrix);

            //int[,] matrix = new int[8, 8]
            //{
            //    {0, 9, 8, 0, 0, 0, 0, 0},
            //    {9, 0, 8, 8, 0, 0, 0, 0},
            //    {8, 8, 0, 0, 5, 3, 0, 0},
            //    {0, 8, 0, 0, 0, 6, 0, 0},
            //    {0, 0, 5, 0, 0, 0, 7, 9},
            //    {0, 0, 3, 6, 0, 0, 0, 4},
            //    {0, 0, 0, 0, 7, 0, 0, 0},
            //    {0, 0, 0, 0, 9, 4, 0, 0},
            //};

            //Graph node_1 = new Graph(1);
            //Graph node_2 = new Graph(2);
            //Graph node_3 = new Graph(3);
            //Graph node_4 = new Graph(4);
            //Graph node_5 = new Graph(5);
            //Graph node_6 = new Graph(6);
            //Graph node_7 = new Graph(7);
            //Graph node_8 = new Graph(8);

            //List<Graph> nodes = new List<Graph> { node_1, node_2, node_3, node_4, node_5, node_6, node_7, node_8 };

            //node_5.Dijkstra(nodes, matrix);

            Console.ReadKey();
        }
    }
}
