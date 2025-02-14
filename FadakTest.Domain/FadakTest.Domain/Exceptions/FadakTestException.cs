namespace FadakTest.Domain.Exceptions
{
    public class FadakTestException : Exception
    {
        public ErrorCode Code { get; set; }

        public FadakTestException(ErrorCode code, string message) : base(message)
        {
            Code = code;
        }
    }
}
