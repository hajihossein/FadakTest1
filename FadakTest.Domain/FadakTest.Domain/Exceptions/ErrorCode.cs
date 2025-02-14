namespace FadakTest.Domain.Exceptions
{
    public enum ErrorCode
    {
        ResourceNotFound = 404_000,
        Internal = 500_000,
        NotSupportedArgument = 300_000,
        DuplicatedName = 300_001,
        UsedData = 300_002
    }
}
