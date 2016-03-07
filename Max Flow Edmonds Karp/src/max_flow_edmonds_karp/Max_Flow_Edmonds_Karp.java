/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package max_flow_edmonds_karp;

import java.util.List;
import java.util.ArrayList;

/**
 *
 * @author Виктор
 */
public class Max_Flow_Edmonds_Karp {

    /**
     * @param args the command line arguments
     */
    
    static class Edge 
    {
        int source, destination, reverse, capacity, f;

        public Edge(int source, int destination, int reverse, int capacity) 
        {
            this.source = source;
            this.destination = destination;
            this.reverse = reverse;
            this.capacity = capacity;
        }
    }
    
    public static List<Edge>[] createGraph(int nodes) 
    {
        List<Edge>[] graph = new List[nodes];
        
        for (int i = 0; i < nodes; i++)
        {
            graph[i] = new ArrayList<>();
        }
        
        return graph;
    }
    
    public static void addEdge(List<Edge>[] graph, int s, int t, int cap) 
    {
        graph[s].add(new Edge(s, t, graph[t].size(), cap));
        graph[t].add(new Edge(t, s, graph[s].size() - 1, 0));
    }
    
    public static int maxFlow(List<Edge>[] graph, int s, int t) 
    {
        int flow = 0;
        int[] q = new int[graph.length];
        
        while (true) 
        {
            int qt = 0;
            q[qt++] = s;
            Edge[] pred = new Edge[graph.length];
            
            for (int qh = 0; qh < qt && pred[t] == null; qh++) 
            {
                int cur = q[qh];
                for (Edge e : graph[cur]) 
                {
                    if (pred[e.destination] == null && e.capacity > e.f) 
                    {
                        pred[e.destination] = e;
                        q[qt++] = e.destination;
                    }
                }
            }
            
            if (pred[t] == null)
            {
                break;
            }
            
            int df = Integer.MAX_VALUE;
            
            for (int u = t; u != s; u = pred[u].source)
            {
                df = Math.min(df, pred[u].capacity - pred[u].f);
            }
            
            for (int u = t; u != s; u = pred[u].source) 
            {
                pred[u].f += df;
                graph[pred[u].destination].get(pred[u].reverse).f -= df;
            }
            flow += df;
        }
        return flow;
    }
  
    public static void main(String[] args) 
    {
        // TODO code application logic here
        
        List<Edge>[] graph = createGraph(7);
        
        addEdge(graph, 0, 1, 10);
        addEdge(graph, 0, 2, 10);
        addEdge(graph, 2, 3, 3);
        addEdge(graph, 1, 3, 5);
        addEdge(graph, 2, 4, 1);
        addEdge(graph, 4, 5, 2);
        addEdge(graph, 3, 5, 2);
        
        System.out.println(maxFlow(graph, 0, 5));
    } 
}
