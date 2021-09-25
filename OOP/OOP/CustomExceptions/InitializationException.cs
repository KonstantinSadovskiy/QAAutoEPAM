using System;

public class InitializationException : Exception
{
    private const string DefaultMessage = "Can't initialize the object.";

    public InitializationException() : base(DefaultMessage)
    {
    }

    public InitializationException(string message) : base(String.Format(DefaultMessage, " ", message))
    {
    }

    public InitializationException(string message, Exception inner)
        : base(message, inner)
    {
    }
}