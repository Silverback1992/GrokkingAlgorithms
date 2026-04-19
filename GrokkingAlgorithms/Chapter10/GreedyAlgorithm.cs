using System;
using System.Collections.Generic;
using System.Linq;

namespace GrokkingAlgorithms.Chapter10;

public static class GreedyAlgorithm
{
    public static List<string> GetStations(HashSet<string> statesNeeded, Dictionary<string, HashSet<string>> stations)
    {
        var finalStates = new List<string>();

        while (statesNeeded.Count > 0)
        {
            string? bestStation = null;
            var statesCovered = new HashSet<string>();

            foreach (var station in stations)
            {
                var covered = statesNeeded.Intersect(station.Value).ToHashSet();

                if (covered.Count > statesCovered.Count)
                {
                    bestStation = station.Key;
                    statesCovered = covered;
                }
            }

            if (bestStation == null || statesCovered.Count == 0)
            {
                throw new InvalidOperationException($"No station can cover the remaining states: {string.Join(", ", statesNeeded)}");
            }

            statesNeeded.ExceptWith(statesCovered);
            finalStates.Add(bestStation);
        }

        return finalStates;
    }
}
