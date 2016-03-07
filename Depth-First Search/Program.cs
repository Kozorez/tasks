using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    class DFS
    {
        int node;
        DFS[] sons;
        
        public DFS(int n, params DFS[] s)
        {
            node = n;
            sons = s;
        }

        void DFS_search()
        {
            for (int i = 0; i < sons.Length; i++)
            {
                sons[i].DFS_search();
            }
            Console.WriteLine(node);
        }

        static void Main(string[] args)
        {
            DFS node_11 = new DFS(11);
            DFS node_4 = new DFS(4);
            DFS node_8 = new DFS(8);
            DFS node_7 = new DFS(7);
            DFS node_1 = new DFS(1);
            DFS node_13 = new DFS(13, node_11, node_4);
            DFS node_10 = new DFS(10);
            DFS node_5 = new DFS(5);
            DFS node_12 = new DFS(12, node_8);
            DFS node_6 = new DFS(6, node_7, node_1);
            DFS node_9 = new DFS(9, node_13, node_10);
            DFS node_3 = new DFS(3, node_5, node_12);
            DFS node_2 = new DFS(2, node_6, node_9, node_3);

            node_2.DFS_search();

            //DFS node_2 = new DFS(2);
            //DFS node_4 = new DFS(4);
            //DFS node_3 = new DFS(3);
            //DFS node_1 = new DFS(1, node_2, node_4, node_3);
            //DFS node_5 = new DFS(5, node_1);

            //node_5.DFS_search();

            Console.ReadKey(); 
        }
    }
}
