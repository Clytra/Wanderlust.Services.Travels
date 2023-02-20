namespace Wanderlust.Services.Travels.Core.Exceptions
{
    internal class InvalidTravelStartException : DomainException
    {
        public override string Code { get; } = "invalid_travel_start_trip";

        public InvalidTravelStartException(DateTime startDate)
            : base($"Start trip date is invalid: {startDate}") { }
    }
}
