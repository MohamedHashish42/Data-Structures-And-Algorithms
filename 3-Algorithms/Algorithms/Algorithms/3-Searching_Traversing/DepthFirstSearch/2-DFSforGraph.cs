using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching_Traversing
{
    class DFSforGraph<T>
    {
        public static void DFSUtil(T v, List<T> visited, Graph<T> graph)
        {

            visited.Add(v);
            Console.Write(v + " ");

            var vList = graph.AdjacentList[v];
            foreach (var n in vList)
            {
                if (!visited.Contains(n))
                    DFSUtil(n, visited, graph);
            }
        }


        public static void DFS(Graph<T> graph, T v)
        {

            var visited = new List<T>();
            DFSUtil(v, visited, graph);
        }


        public static void DFS(Graph<T> graph)
        {
            var visited = new List<T>();
            foreach (var item in graph.AdjacentList)
            {
                if (!visited.Contains(item.Key))
                    DFSUtil(item.Key, visited, graph);
            }    
            

        }
    }
}
