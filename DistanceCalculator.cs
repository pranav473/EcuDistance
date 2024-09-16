using System;

class DistanceCalculator
{
    static void Main()
    {
        // Directions and initial coordinates
        string direction = "15F6B6B5L16R8B16F20L6F13F11R";
        int x = 0, y = 0;

        // Iterate through the string to extract steps and direction
        for (int index = 0; index < direction.Length;)
        {
            // Calculate the number of steps for the current move
            int stepsCount = 0;
            while (index < direction.Length && char.IsDigit(direction[index]))
            {
                stepsCount = stepsCount * 10 + (direction[index] - '0');
                index++;
            }

            // Get the movement direction
            char moveDirection = direction[index];
            index++;

            // Adjust coordinates based on the movement direction
            if (moveDirection == 'F') 
                y += stepsCount; // Move up
            else if (moveDirection == 'B') 
                y -= stepsCount; // Move down
            else if (moveDirection == 'L') 
                x -= stepsCount; // Move left
            else if (moveDirection == 'R') 
                x += stepsCount; // Move right
        }

        // Calculate Euclidean distance using Pythagoras' theorem
        double eucDistance = Math.Sqrt(x*x+y*y);

        // Display the computed distance
        Console.WriteLine($"Euclidean Distance from the starting point: {eucDistance:0.00}");
    }
}