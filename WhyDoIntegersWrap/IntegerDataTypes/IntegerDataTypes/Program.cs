using System;

namespace IntegerDataTypes
{
    /// <summary>
    /// Integer Data Types lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates integer data types
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 100;
            const int SecondsPerMinute = 60;

            // calculate minutes and seconds played
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;

            // print minutes and seconds played
            Console.WriteLine("Minutes Played: " + minutesPlayed);
            Console.WriteLine("Seconds Played: " + secondsPlayed);
        }
    }
}
