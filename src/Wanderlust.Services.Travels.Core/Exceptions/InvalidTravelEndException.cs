namespace Wanderlust.Services.Travels.Core.Exceptions
{
    internal class InvalidTravelEndException : DomainException
    {
        public override string Code { get; } = "invalid_travel_end";

        public InvalidTravelEndException(DateTime endDate)
            : base($"Travel end date is invalid: {endDate}") { }
    }
}
