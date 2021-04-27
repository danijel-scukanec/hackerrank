using System;
using System.Collections.Generic;

namespace HackerRank.StacksAndQueues.CastleOnTheGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(minimumMoves(new string[] { ".X.", ".X.", "..." }, 0, 0, 0, 2));
            //Console.WriteLine(minimumMoves(new string[] { "...", ".X.", ".X." }, 2, 0, 0, 2));
            Console.WriteLine(minimumMoves(new string[] {
                ".X..XX...X",
                "X.........",
                ".X.......X",
                "..........",
                "........X.",
                ".X...XXX..",
                ".....X..XX",
                ".....X.X..",
                "..........",
                ".....X..XX"
            }, 9, 1, 9, 6));
        }

        static int minimumMoves(string[] grid, int startX, int startY, int goalX, int goalY)
        {
            var graph = new Graph<(int, int)>();
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid.Length; j++)
                {
                    if (grid[i][j] == 'X')
                    {
                        continue;
                    }

                    graph.AddVertex((i, j));
                }
            }

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid.Length; j++)
                {
                    if (grid[i][j] == 'X')
                    {
                        continue;
                    }

                    if (j + 1 < grid.Length && grid[i][j + 1] != 'X')
                    {
                        graph.AddEdge(new Tuple<(int, int), (int, int)>((i, j), (i, j + 1)));
                    }

                    if (i + 1 < grid.Length && grid[i + 1][j] != 'X')
                    {
                        graph.AddEdge(new Tuple<(int, int), (int, int)>((i, j), (i + 1, j)));
                    }
                }
            }

            var counter = BFS(graph, (startX, startY), (goalX, goalY), grid.Length);
            return counter;
        }

        static int BFS(Graph<(int, int)> graph, (int, int) start, (int, int) goal, int gridLength)
        {
            var counter = 0;
            var visited = new HashSet<(int, int)>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return counter;

            var queue = new Queue<(int, int)>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);
                if (vertex.Item1 == goal.Item1 && vertex.Item2 == goal.Item2)
                {
                    return counter;
                }

                foreach (var neighbor in graph.AdjacencyList[vertex])
                {
                    if (visited.Contains(neighbor))
                    {
                        continue;
                    }

                    queue.Enqueue(neighbor);

                    //column to the left
                    if (vertex.Item1 == neighbor.Item1 && vertex.Item2 > neighbor.Item2 && (neighbor.Item2 == 0 || neighbor.Item2 == 'X'))
                    {
                        Console.WriteLine($"X:{vertex.Item1} Y:{vertex.Item2}");
                        counter++;
                    }
                    //column to the right
                    else if (vertex.Item1 == neighbor.Item1 && vertex.Item2 < neighbor.Item2 && (neighbor.Item2 == gridLength - 1 || neighbor.Item2 == 'X'))
                    {
                        Console.WriteLine($"X:{vertex.Item1} Y:{vertex.Item2}");
                        counter++;
                    }
                    //row to the bottom
                    else if (vertex.Item2 == neighbor.Item2 && vertex.Item1 < neighbor.Item1 && (neighbor.Item1 == gridLength - 1 || neighbor.Item1 == 'X'))
                    {
                        Console.WriteLine($"X:{vertex.Item1} Y:{vertex.Item2}");
                        counter++;
                    }
                    //row to the top
                    else if (vertex.Item2 == neighbor.Item2 && vertex.Item1 > neighbor.Item1 && (neighbor.Item1 == 0 || neighbor.Item1 == 'X'))
                    {
                        Console.WriteLine($"X:{vertex.Item1} Y:{vertex.Item2}");
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}
