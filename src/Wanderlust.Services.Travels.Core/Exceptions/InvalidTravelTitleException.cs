namespace Wanderlust.Services.Travels.Core.Exceptions
{
    internal class InvalidTravelTitleException : DomainException
    {
        public override string Code { get; } = "invalid_travel_title";

        public InvalidTravelTitleException(string title)
            : base($"Travel title is invalid: {title}") { }
    }
}
