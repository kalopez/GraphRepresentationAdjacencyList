GraphRepresentationAdjacencyList
============================
Description:

This program prints the nodes that are adjacent to each vertex. The graph is represented using an adjacency list. 
Adjacency Lists are best for graphs that are sparse or for whom the number of edges is much less than the number 
of vertices. Since it only stores which nodes are connected it helps save a lot of space compared to other methods. 
The disadvantage of using an Adjacency List is that time complexity for finding connections between vertices is increased compared to other methods.

This program can also find all the vertices that are connected to a vertex, as well as if two vertices in the graph are connected.

Space complexity is O(V) where V is number of vertices. 
Time complexity for printing out matrix is O(V^2), for finding all connected nodes is O(v) and for finding if two nodes are connected is O(v). These are the worst case
scenarios, however, and many times it will be better than this, especially if it is a sparse graph.


++++++++++++++++++++++++++++++

Author: Katherine Lopez

++++++++++++++++++++++++++++++