using System;

public class GetAutoByParameterException : Exception
{
    private const string DefaultMessage = "Can't find chosen parameter.";

    public GetAutoByParameterException() : base(DefaultMessage)
    {
    }

    public GetAutoByParameterException(string message) : base(message)
    {
    }

    public GetAutoByParameterException(string message, Exception inner)
        : base(message, inner)
    {
    }
}