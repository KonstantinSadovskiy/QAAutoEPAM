using System;

public class RemoveAutoException : Exception
{
    private const string DefaultMessage = "Can't remove object.";

    public RemoveAutoException() : base(DefaultMessage)
    {
    }

    public RemoveAutoException(string message) : base(message)
    {
    }

    public RemoveAutoException(string message, Exception inner)
        : base(message, inner)
    {
    }
}