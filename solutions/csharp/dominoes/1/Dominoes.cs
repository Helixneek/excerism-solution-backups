public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        if(!dominoes.Any()) return true; 

        // Degree count check
        // Every number must appear an even amount of times
        Dictionary<int, int> degreeCounts = new();
        foreach(var (a, b) in dominoes) {
            degreeCounts[a] = degreeCounts.GetValueOrDefault(a) + 1;
            degreeCounts[b] = degreeCounts.GetValueOrDefault(b) + 1;
        }

        // If its odd, that means a full chain is impossible
        foreach(var degs in degreeCounts.Values) {
            if(degs % 2 != 0) return false;
        }
        
        Dictionary<int, List<int>> adjacencyList = new();
        HashSet<int> visited = new();
        Stack<int> stack = new();

        // Populate the AL
        foreach(var (a, b) in dominoes) {
            // Check if key 1 exists or not
            if(!adjacencyList.ContainsKey(a)) {
                adjacencyList[a] = new();
            }

            adjacencyList[a].Add(b);

            // Check if key 2 exists or not
            if(!adjacencyList.ContainsKey(b)) {
                adjacencyList[b] = new();
            }

            adjacencyList[b].Add(a);
        }

        // Pick a starting node
        int startNode = adjacencyList.Keys.First();

        // Put the node into the tracking tools
        stack.Push(startNode);
        visited.Add(startNode);

        // TRAVERSAL
        while(stack.Count > 0) {
            int top = stack.Pop();
            foreach(int neighbor in adjacencyList[top]) {
                if(visited.Contains(neighbor)) continue;

                visited.Add(neighbor);
                stack.Push(neighbor);
            }
        }

        // Check if we could explore all dominoes
        // If its not equal, that means there were some islands
        return visited.Count == adjacencyList.Count;
    }
}