namespace Wanderlust.Services.Travels.Core.Exceptions
{
    internal class DomainException : Exception
    {
        public virtual string Code { get; }

        protected DomainException(string message) : base(message) { }
    }
}
