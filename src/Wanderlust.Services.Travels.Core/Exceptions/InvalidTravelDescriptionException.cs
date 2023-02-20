namespace Wanderlust.Services.Travels.Core.Exceptions
{
    internal class InvalidTravelDescriptionException : DomainException
    {
        public override string Code { get; } = "invalid_travel_description";

        public InvalidTravelDescriptionException(string description)
            : base($"Travel description is invalid: {description}") { }
    }
}
