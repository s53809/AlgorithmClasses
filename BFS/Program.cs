using System;
using System.Collections.Generic;

namespace BFS
{
    class Graph
    {
        const Int32 v_count = 6;
        List<Int32>[] adj = new List<Int32>[]
        {
            new List<Int32>{1,3 },
            new List<Int32>{0,2,3 },
            new List<Int32>{1 },
            new List<Int32>{0,1,4 },
            new List<Int32>{3,5 },
            new List<Int32>{4 }
        };

 
        /*Int32[,] adj = new Int32[v_count, v_count]
        {
            { 0, 1, 0, 1, 0, 0 },
            { 1, 0, 1, 1, 0, 0 },
            { 0, 1, 0, 0, 0, 0 },
            { 1, 1, 0, 0, 1, 0 },
            { 0, 0, 0, 1, 0, 1 },
            { 0, 0, 0, 0, 1, 0 }
        };*/

        public void BFS(Int32 start)
        {
            Boolean[] visited = new Boolean[v_count];

            Queue<Int32> qu = new Queue<Int32>();

            qu.Enqueue(start);
            visited[start] = true;

            while(qu.Count > 0)
            {
                Int32 dist = qu.Dequeue();
                Console.Write(dist.ToString() + "->");

                foreach(Int32 next in adj[dist])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        qu.Enqueue(next);
                    }
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph();

            Console.WriteLine("탐색 시작");
            g.BFS(0);
            Console.WriteLine("탐색 끝");
        }
    }
}
