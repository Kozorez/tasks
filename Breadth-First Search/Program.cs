using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    class BFS
    {
        int node;
        BFS[] sons;
        bool marked;

        public BFS(int n, params BFS[] s)
        {
            node = n;
            sons = s;
            marked = false;
        }

        void BFS_search()
        {
            marked = true;
            Queue<BFS> nodes = new Queue<BFS>();
            nodes.Enqueue(this);
            Console.WriteLine(node);
            while (nodes.Count != 0)
            {
                BFS vertex = nodes.Dequeue();
                for (int i = 0; i < vertex.sons.Length; i++)
                {
                    if (!vertex.sons[i].marked)
                    {
                        vertex.sons[i].marked = true;
                        Console.WriteLine(vertex.sons[i].node);
                        nodes.Enqueue(vertex.sons[i]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            BFS node_11 = new BFS(11);
            BFS node_4 = new BFS(4);
            BFS node_8 = new BFS(8);
            BFS node_7 = new BFS(7);
            BFS node_1 = new BFS(1);
            BFS node_13 = new BFS(13, node_11, node_4);
            BFS node_10 = new BFS(10);
            BFS node_5 = new BFS(5);
            BFS node_12 = new BFS(12, node_8);
            BFS node_6 = new BFS(6, node_7, node_1);
            BFS node_9 = new BFS(9, node_13, node_10);
            BFS node_3 = new BFS(3, node_5, node_12);
            BFS node_2 = new BFS(2, node_6, node_9, node_3);
            
            node_2.BFS_search();

            //BFS node_2 = new BFS(2);
            //BFS node_4 = new BFS(4);
            //BFS node_3 = new BFS(3);
            //BFS node_1 = new BFS(1, node_2, node_4, node_3);
            //BFS node_5 = new BFS(5, node_1);

            //node_5.BFS_search();

            Console.ReadKey(); 
        }
    }
}
