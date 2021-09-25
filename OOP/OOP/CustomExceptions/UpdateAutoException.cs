using System;

public class UpdateAutoException : Exception
{
    private const string DefaultMessage = "Can't update object.";

    public UpdateAutoException() : base(DefaultMessage)
    {
    }

    public UpdateAutoException(string message) : base(message)
    {
    }

    public UpdateAutoException(string message, Exception inner)
        : base(message, inner)
    {
    }
}