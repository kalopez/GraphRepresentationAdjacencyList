using System;
using System.Collections.Generic;

namespace GraphRepresentationAdjacencyList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adjacency List keeps a list of connected nodes
            //is best for sparse graphs with number of edges is much smaller than number of vertices squared.

            //Create adjacency list
            Dictionary<char, List<char>> connections = new Dictionary<char, List<char>>();
            connections.Add('A', new List<char>() { 'B', 'C', 'D' });  //A is connected to B,C,D
            connections.Add('B', new List<char>() { 'A', 'E', 'F' });  //B is connected to A,E,F
            connections.Add('C', new List<char>() { 'A', 'G' });      //C is connected to A,G
            connections.Add('D', new List<char>() { 'A', 'H' });      //D is connected to A,H
            connections.Add('E', new List<char>() { 'B', 'H' });      //E is connected to B,H
            connections.Add('F', new List<char>() { 'B', 'H' });      //F is connecteed to B,H
            connections.Add('G', new List<char>() { 'C', 'H' });      //G is connected to C,H
            connections.Add('H', new List<char>() { 'D', 'E', 'F', 'G' }); //H is connected to D,E,F,G

            PrintAdjacencyList(connections);

            //Allow user to decide whether to exit, find adjacent nodes or find if two nodes are connected
            Console.WriteLine("\nPress 'Esc' to exit the process\n Press'S' to find a node's neighbors\n Press 'T' to find if two nodes are connected");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            //Exit console
            if (keyInfo.Key == ConsoleKey.Escape)
                Environment.Exit(0);

            //Find adjacent nodes
            while (keyInfo.Key == ConsoleKey.S)
            {
                PrintAdjacentNodes(connections);
                keyInfo = Console.ReadKey(true);
            }

            //Find if two nodes are connected
            while (keyInfo.Key == ConsoleKey.T)
            {
                FindIfTwoNodesAreConnected(connections);
                keyInfo = Console.ReadKey(true);

            }

        }

        //Prints the adjacency List. Time complexity is O(n) or linear time.
        public static void PrintAdjacencyList(Dictionary<char, List<char>> connections)
        {
            foreach (KeyValuePair<char, List<char>> row in connections)
            {
                Console.Write(row.Key + "=> ");
                foreach (var vertex in row.Value)
                {
                    Console.Write(vertex);
                }
                Console.WriteLine();
            }
        }

        //Find nodes adjacent to a particular vertice specified by user. Time complexity is O(n) or linear time.
        static void PrintAdjacentNodes(Dictionary<char, List<char>> connections)
        {
            Console.WriteLine();
            Console.WriteLine("Enter a specific node to find its neighbors");
            char node = Console.ReadLine().ToUpper().ToCharArray()[0];
            Console.Write(node + "=> ");
            if (connections.TryGetValue(node, out List<char> neighbors))
            {
                foreach (char neighbor in neighbors)
                    Console.Write(neighbor);
                Console.WriteLine();
            }
            else
                Console.Write("Node not found");
            Console.WriteLine();
            Console.WriteLine("\nPress 'Esc' to exit the process\n Press'S' to find a node's neighbors\n Press 'T' to find if two nodes are connected");
        }

        //Find if the two nodes specified by user are connected. Time complexity is O(n) or linear time.
        static void FindIfTwoNodesAreConnected(Dictionary<char, List<char>> connections)
        {
            Console.WriteLine();
            Console.WriteLine("Enter two nodes with no space in between find out if they are connected");
            char[] nodes = Console.ReadLine().ToUpper().ToCharArray();
            bool foundValue = false;
            if (connections.TryGetValue(nodes[0], out List<char> neighbors))
            {
                foreach (char neighbor in neighbors)
                {
                    if (neighbor == nodes[1])
                        foundValue = true;
                }
            }
            if (foundValue)
                Console.WriteLine("Yes, they are connected");
            else
                Console.WriteLine("No, they are not connected");

            Console.WriteLine("\nPress 'Esc' to exit the process\n Press'S' to find a node's neighbors\n Press 'T' to find if two nodes are connected");
        }
    }
}

