DistanceCalculator

This C# program calculates the Euclidean distance from the starting point after following a series of movement instructions. The program processes a string of directions with the following possible movements:

    F: Move forward (increase Y-coordinate)
    B: Move backward (decrease Y-coordinate)
    L: Move left (decrease X-coordinate)
    R: Move right (increase X-coordinate)

The program extracts the steps and movements from the string, updates the coordinates, and finally calculates the Euclidean distance using the Pythagorean theorem.
Prerequisites

    .NET SDK installed on your machine.
    A text editor or IDE to edit and run the program (e.g., Visual Studio, Visual Studio Code).

How to Run the Program

    Clone or download the program to your local machine.

    Open a terminal or command prompt in the directory where the file is saved.

    Compile and run the program using the following command:

        "dotnet run"

    The output will display the Euclidean distance from the starting point based on the direction string provided in the code.

Example

For the input string:

    15F6B6B5L16R8B16F20L6F13F11R

    F = Forward
    B = Backward
    L = Left
    R = Right

The program will compute the distance after all the movements and print the result like this:


    Euclidean Distance from the starting point: 22.63

Feel free to modify the direction string in the code to test different scenarios
