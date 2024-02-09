using System;

public class Temperature
{
    private double temperature;

    public Temperature(double temp)
    {
        temperature = temp;
    }

    public void DisplayTemperature()
    {
        if (temperature == 0)
        {
            throw new TempIsZeroException("Temperature is zero.");
        }
        else
        {
            Console.WriteLine($"The temperature is: {temperature} degrees Celsius");
        }
    }
}
