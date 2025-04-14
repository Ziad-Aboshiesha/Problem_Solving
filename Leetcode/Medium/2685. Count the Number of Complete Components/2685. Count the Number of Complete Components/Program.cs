namespace _2685._Count_the_Number_of_Complete_Components
{

    public class Solution
    {

        // time  : O( n + m)
        // space : O(n  + m)
        public int CountCompleteComponents(int n, int[][] edges)
        {
            // Step 1: Build the adjacency list
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            HashSet<int> nodesWithEdges = new HashSet<int>();

            for (int i = 0; i < n; i++)
                graph[i] = new List<int>();

            foreach (var edge in edges)
            {
                int u = edge[0], v = edge[1];
                graph[u].Add(v);
                graph[v].Add(u);
                nodesWithEdges.Add(u);
                nodesWithEdges.Add(v);
            }

            // Step 2: Use BFS/DFS to find connected components
            HashSet<int> visited = new HashSet<int>();
            int completeComponents = 0;

            for (int i = 0; i < n; i++)
            {
                if (!visited.Contains(i)) // New component found
                {
                    List<int> component = new List<int>();
                    Queue<int> queue = new Queue<int>();
                    queue.Enqueue(i);
                    visited.Add(i);

                    // BFS to collect all nodes in the component
                    while (queue.Count > 0)
                    {
                        int node = queue.Dequeue();
                        component.Add(node);

                        foreach (int neighbor in graph[node])
                        {
                            if (!visited.Contains(neighbor))
                            {
                                visited.Add(neighbor);
                                queue.Enqueue(neighbor);
                            }
                        }
                    }

                    // Step 3: Check if the component is complete
                    int size = component.Count;
                    int expectedEdges = (size * (size - 1)) / 2;
                    int actualEdges = 0;

                    foreach (int node in component)
                        actualEdges += graph[node].Count;

                    actualEdges /= 2; // Each edge is counted twice

                    if (actualEdges == expectedEdges)
                        completeComponents++;
                }
            }

            return completeComponents;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
