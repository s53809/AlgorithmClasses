using System;
using System.Collections.Generic;

namespace DFS
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

        private Boolean[] visited = new Boolean[v_count];

        public void DFS(Int32 start)
        {
            visited[start] = true;
            Console.Write(start.ToString() + "->");
            foreach(Int32 next in adj[start])
            {
                if (!visited[next])
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
            g.DFS(3);
            Console.WriteLine("탐색 끝");
        }
    }
}
