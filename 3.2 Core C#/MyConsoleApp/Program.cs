using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter distance in meters:");
        double distance = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter time in hours:");
        double hours = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter time in minutes:");
        double minutes = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter time in seconds:");
        double seconds = double.Parse(Console.ReadLine()!);

        double totalTimeInHours = hours + (minutes / 60) + (seconds / 3600);

        double speedInMetersPerSecond = distance / totalTimeInHours;

        double speedInKilometersPerHour = speedInMetersPerSecond * 3.6;

        double speedInMilesPerHour = speedInMetersPerSecond * 2.23694;

        Console.WriteLine("\nYour speed in metres/sec is: " + distance / (hours * 3600 + minutes * 60 + seconds));
        Console.WriteLine("\nYour speed in km/h is: " + (distance / 1000) / (hours + minutes / 60 + seconds / 3600));
        Console.WriteLine("\nYour speed in miles/h is: " + (distance * 0.62137119) / (hours + minutes / 60 + seconds / 3600));
    }
}
