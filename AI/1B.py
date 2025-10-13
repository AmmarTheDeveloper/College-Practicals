from collections import deque
def bfs_graph(start_node,graph):
    visited = set()
    queue = deque([start_node])
    order = []
    while queue:
        node = queue.popleft()
        if node not in visited:
            visited.add(node)
            order.append(node)
        for neighbor in graph.get(node,[]):
            if neighbor not in visited:
                queue.append(neighbor)

    return order
print("Suraj kanojiya 318");

graph = {
    'A': ['B', 'C'],
    'B': ['A', 'D', 'E'],
    'C': ['A', 'F'],
    'D': ['B'],
    'E': ['B', 'F'],
    'F': ['C', 'E']
    }
start_node = 'A'
bfs_order = bfs_graph(start_node,graph)
print("BFS Order:",bfs_order)
    
