using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Graph
{
    class GraphPrctices
    {
        public static void CustomGraph()
        {
            Graph<string> myGraph = new Graph<string>();
            myGraph.AddVertex("A");
            myGraph.AddVertex("B");
            myGraph.AddVertex("C");
            myGraph.AddVertex("D");
            myGraph.AddEdge("A", "B");
            myGraph.AddEdge("A", "C");
            myGraph.AddEdge("B", "C");
            myGraph.AddEdge("C", "D");
    

            myGraph.ShowConnections();
        }
    }
}
