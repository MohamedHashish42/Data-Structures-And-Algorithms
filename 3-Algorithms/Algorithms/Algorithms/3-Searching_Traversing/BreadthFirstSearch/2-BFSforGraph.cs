using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Searching_Traversing
{
    class BFSforGraph<T>
    {
        public static void BFS(Graph<T> graph, T v)
        {
            var visited = new List<T>();



            Queue<T> queue = new Queue<T>();

            // Mark the current node as
            // visited and enqueue it
            visited.Add(v);
            queue.Enqueue(v);

            while (queue.Any())
            {

                v = queue.First();
                Console.Write(v + " ");
                queue.Dequeue();

                var list = graph.AdjacentList[v];

                foreach (var val in list)
                {
                    if (!visited.Contains(val))
                    {
                        visited.Add(val);
                        queue.Enqueue(val);
                    }
                }
            }
        }

        public static void BFS(Graph<T> graph)
        {
            var visited = new List<T>();
            foreach (var adj in graph.AdjacentList)
            {


                if (!visited.Contains(adj.Key))
                {
                    Queue<T> queue = new Queue<T>();

                    // Mark the current node as
                    // visited and enqueue it
                    visited.Add(adj.Key);
                    queue.Enqueue(adj.Key);

                    while (queue.Any())
                    {

                        var v = queue.First();
                        Console.Write(v + " ");
                        queue.Dequeue();

                        var list = graph.AdjacentList[v];

                        foreach (var val in list)
                        {
                            if (!visited.Contains(val))
                            {
                                visited.Add(val);
                                queue.Enqueue(val);
                            }
                        }
                    }
                }
            }
        }
    }
}
