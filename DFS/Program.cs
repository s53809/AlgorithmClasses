using System;
using System.Collections.Generic;

namespace DFS
{
    class Graph
    {
        const Int32 v_count = 6;

        Int32[,] adj = new Int32[v_count, v_count]
        {
            { 0, 1, 0, 1, 0, 0 },
            { 1, 0, 1, 1, 0, 0 },
            { 0, 1, 0, 0, 0, 0 },
            { 1, 1, 0, 0, 1, 0 },
            { 0, 0, 0, 1, 0, 1 },
            { 0, 0, 0, 0, 1, 0 }
        };

        private Boolean[] visited = new Boolean[v_count];

        public void DFS(Int32 start)
        {
            visited[start] = true;
            Console.Write(start.ToString() + "->");
            for(Int32 next = 0; next < v_count; next++)
            {
                if(adj[start,next] == 1 && !visited[next])
                {
                    DFS(next);
                    Console.Write("back->");
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
            g.DFS(0);
            Console.WriteLine("\n탐색 끝");
        }
    }
}
