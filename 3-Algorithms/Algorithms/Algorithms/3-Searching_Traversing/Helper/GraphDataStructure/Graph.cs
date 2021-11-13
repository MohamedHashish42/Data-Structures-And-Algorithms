using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching_Traversing
{
    class Graph<T>
    {
        public int NumOfNodes { get; set; }

        public Dictionary<T, List<T>> AdjacentList { get; set; }

        public bool Directed { get; set; }

        public Graph(bool directed = false)
        {
            Directed = directed;
            NumOfNodes = 0;
            AdjacentList = new Dictionary<T, List<T>>();
        }
        public void AddVertex(T node)
        {
            AdjacentList.Add(node, new List<T>());
            NumOfNodes++;
        }

        public void AddEdge(T node1, T node2)
        {
            if (Directed)
            {
                AdjacentList[node1].Add(node2);
                return;
            }

            AdjacentList[node1].Add(node2);
            AdjacentList[node2].Add(node1);
        }
        public void ShowConnections()
        {

            foreach (var item in AdjacentList)
            {
                List<T> nodeConnections = AdjacentList[item.Key];
                StringBuilder connections = new StringBuilder();
                for (int i = 0; i < nodeConnections.Count; i++)
                {
                    connections.Append(nodeConnections[i]).Append(" ");
                }
                Console.WriteLine(item.Key + "-->" + connections);

            }
        }
    }
}
