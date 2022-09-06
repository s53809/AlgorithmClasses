using System;
using System.Collections.Generic;

namespace BFS
{
    class Graph
    {
        const Int32 v_count = 6;

        Int32[,] adj = new Int32[6, 6]
        {
            { 0, 1, 0, 1, 0, 0 },
            { 1, 0, 1, 1, 0, 0 },
            { 0, 1, 0, 0, 0, 0 },
            { 1, 1, 0, 0, 1, 0 },
            { 0, 0, 0, 1, 0, 1 },
            { 0, 0, 0, 0, 1, 0 }
        };

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

                for(Int32 next = 0; next < v_count; next++)
                {
                    if (adj[dist, next] == 1 && !visited[next])
                    {
                        qu.Enqueue(next);
                        visited[next] = true;
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
