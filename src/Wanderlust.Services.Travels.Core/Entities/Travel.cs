using Wanderlust.Services.Travels.Core.Exceptions;

namespace Wanderlust.Services.Travels.Core.Entities
{
    internal class Travel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime StartTrip { get; set; }
        public DateTime EndTrip { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }

        public Travel(Guid id, string title, DateTime startTrip, DateTime endTrip, 
            string description, Category category)
        {
            Id = id;
            ChangeTitle(title);
            ChangeStartTrip(startTrip);
            ChangeEndTrip(endTrip);
            ChangeDescription(description);
            Category = category;
        }

        public void ChangeTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
                throw new InvalidTravelTitleException(title);

            Title = title;
        }

        public void ChangeStartTrip(DateTime start)
        {
            if (start != null)
                throw new InvalidTravelStartException(start);

            StartTrip = start;
        }

        public void ChangeEndTrip(DateTime end)
        {
            if (end != null)
                throw new InvalidTravelEndException(end);

            EndTrip = end;
        }

        public void ChangeDescription(string description)
        {
            if (!string.IsNullOrEmpty(description))
                throw new InvalidTravelDescriptionException(description);

            Description = description;
        }
    }
}
