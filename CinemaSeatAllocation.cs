using System;
using System.Collections.Generic;

namespace AlgorithmsExercise;

public class CinemaSeatAllocation
{
    public int MaxNumberOfGroups(int n, int[][] reservedSeats) {
        // 1) Group reserved seats by row
        var rowToReservedSeats = new Dictionary<int, HashSet<int>>();

        foreach (var seat in reservedSeats)
        {
            int row = seat[0];
            int col = seat[1];

            // We could store all seats 1–10; it's still small and easy to reason about.
            if (!rowToReservedSeats.ContainsKey(row))
            {
                rowToReservedSeats[row] = new HashSet<int>();
            }

            rowToReservedSeats[row].Add(col);
        }

        // 2) Rows with no reservations can hold 2 groups each
        long result = (long)(n - rowToReservedSeats.Count) * 2;

        // 3) For rows that do have reservations, calculate per row
        foreach (var kvp in rowToReservedSeats)
        {
            HashSet<int> reservedInRow = kvp.Value;
            int groupsInThisRow = CountGroupsInRow(reservedInRow);
            result += groupsInThisRow;
        }

        // The problem expects an int, but we use long internally for safety.
        return (int)result;
    }
    
    /// <summary>
    /// Given the reserved seats for a single row, decide how many 4-person groups fit.
    /// </summary>
    private int CountGroupsInRow(HashSet<int> reserved)
    {
        bool leftFree   = AreSeatsFree(reserved, 2, 5); // seats 2–5
        bool rightFree  = AreSeatsFree(reserved, 6, 9); // seats 6–9
        bool middleFree = AreSeatsFree(reserved, 4, 7); // seats 4–7 (cross-aisle)

        int groups = 0;

        // Case 1: we can place one group on the left
        if (leftFree)
        {
            groups++;
        }

        // Case 2: we can place one group on the right
        if (rightFree)
        {
            groups++;
        }

        // Case 3: if neither left nor right worked, but the middle 4–7 is free,
        // we can place exactly one group crossing the aisle.
        if (!leftFree && !rightFree && middleFree)
        {
            groups = 1;
        }

        return groups;
    }
    
    /// <summary>
    /// Checks if all seats from startSeat to endSeat (inclusive) are free.
    /// </summary>
    private bool AreSeatsFree(HashSet<int> reserved, int startSeat, int endSeat)
    {
        for (int seat = startSeat; seat <= endSeat; seat++)
        {
            if (reserved.Contains(seat))
            {
                return false;
            }
        }

        return true;
    }
}