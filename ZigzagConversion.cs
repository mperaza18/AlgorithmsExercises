using System.Text;

namespace AlgorithmsExercise;

public class ZigzagConversion
{
    public string Convert(string s, int numRows) {  
        // Edge cases: no zigzag needed
        if (numRows == 1 || numRows >= s.Length)
        {
            return s;
        }

        // Prepare a list of StringBuilders, one per row
        var rows = new List<StringBuilder>();
        for (int i = 0; i < numRows; i++)
        {
            rows.Add(new StringBuilder());
        }

        int currentRow = 0;
        int direction = 1; // 1 = moving down, -1 = moving up

        foreach (char c in s)
        {
            // Add current char to the appropriate row
            rows[currentRow].Append(c);

            // If we reach the top, we start moving down
            if (currentRow == 0)
            {
                direction = 1;
            }
            // If we reach the bottom, we start moving up
            else if (currentRow == numRows - 1)
            {
                direction = -1;
            }

            // Move to the next row according to the direction
            currentRow += direction;
        }

        // Combine all rows into one string
        var result = new StringBuilder();
        foreach (var row in rows)
        {
            result.Append(row.ToString());
        }

        return result.ToString();
    }
}