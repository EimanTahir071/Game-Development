using System;
namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables for points
            float point1X, point1Y, point2X, point2Y;

            // loop while there's more input to read
            string inputString = Console.ReadLine();
            while (inputString[0] != 'q')
            {
                // extract point coordinates from string
                string[] coordinates = inputString.Split(' ');
                point1X = float.Parse(coordinates[0]);
                point1Y = float.Parse(coordinates[1]);
                point2X = float.Parse(coordinates[2]);
                point2Y = float.Parse(coordinates[3]);

                // ADD YOUR CODE BETWEEN THIS COMMENT AND THE ONE BELOW

                // Step 1: Calculate delta x and delta y
                float deltaX = point2X - point1X;
                float deltaY = point2Y - point1Y;

                // Step 2: Calculate distance using Pythagorean theorem
                float distance = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

                // Step 3: Calculate angle using Atan2 and convert to degrees
                float angleRadians = (float)Math.Atan2(deltaY, deltaX);
                float angleDegrees = angleRadians * (float)(180.0 / Math.PI);

                // Step 4: Print the results with proper formatting
                // Check if distance is a whole number
                if (distance == (int)distance)
                {
                    Console.Write((int)distance);
                }
                else
                {
                    Console.Write(distance);
                }

                Console.Write(" ");

                // Check if angle is a whole number
                if (angleDegrees == (int)angleDegrees)
                {
                    Console.Write((int)angleDegrees);
                }
                else
                {
                    Console.Write(angleDegrees);
                }

                Console.WriteLine();

                // ADD YOUR CODE BETWEEN THIS COMMENT AND THE ONE ABOVE

                // attempt to read more input
                inputString = Console.ReadLine();
            }

            // keep the console window open
            Console.ReadLine();
        }
    }
}

