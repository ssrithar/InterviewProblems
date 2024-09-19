using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions
{
    public class Reorder_Routes
    {
        public Dictionary<int, List<(int city, bool direction)>> pathGraph = new();
        public HashSet<int> visitedCity = new();
        public int reversedPathCount = -1;

        public Reorder_Routes()
        {
            var map = SetupMap();
            foreach (var item in map)
            {
                Console.WriteLine();
                foreach (var element in item)
                {
                    Console.Write($"{element} ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("MinReorder");
            var result = MinReorder(5, map);
        }

        public int MinReorder(int n, int[][] connections)
        {
            foreach (var connection in connections)
            {
                var cityA = connection[0];
                var cityB = connection[1];

                pathGraph[cityA] = pathGraph.GetValueOrDefault(cityA, new List<(int, bool)>());
                pathGraph[cityA].Add((cityB, true));

                pathGraph[cityB] = pathGraph.GetValueOrDefault(cityB, new List<(int, bool)>());
                pathGraph[cityB].Add((cityB, false));
            }

            foreach (var graphItem in pathGraph)
            {
                Console.WriteLine($"{graphItem.Key}");
                foreach (var value in graphItem.Value)
                {
                    Console.Write($"{value.city} {value.direction}");
                }
            }

            return -1;
        }

        public int[][] SetupMap()
        {
            int[][] map = new int[5][];

            map[0] = new int[] { 0, 1 };
            map[1] = new int[] { 1, 3 };
            map[2] = new int[] { 2, 3 };
            map[3] = new int[] { 4, 0 };
            map[4] = new int[] { 4, 5 };

            return map;
        }
    }
}
