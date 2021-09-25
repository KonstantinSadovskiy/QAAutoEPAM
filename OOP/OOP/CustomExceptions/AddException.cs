using System;

public class AddException : Exception
{
    private const string DefaultMessage = "Can't add object to list.";

    public AddException() : base(DefaultMessage)
    {
    }

    public AddException(string message) : base(String.Format(DefaultMessage, " ", message))
    {
    }

    public AddException(string message, Exception inner)
        : base(message, inner)
    {
    }
}