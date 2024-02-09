using System;

public class TempIsZeroException : Exception
{
    public TempIsZeroException(string message) : base(message)
    {
    }
}