using Shipping.Domain.Common;
using Shipping.Domain.Common.ValueObjects;
using Shipping.Domain.Route.ValueObjects;

namespace Shipping.Domain.Route;

public class Route
{
    public EntityId Id { get; private set; }
    public RouteTitle Title { get; private set; }
    public CityName From { get; private set; }
    public CityName To { get; private set; }
    public EstimatedTime EstimatedTime { get; private set; }
    public RouteDistance RouteDistance { get; private set; }
    public Price BasePrice { get; private set; }

    private Route()
    {
    }

    public class Builder
    {
        private readonly Route _route = new Route();
        public List<string> Errors { get; private set; } = [];

        public Builder WithNewId()
        {
            return this;
        }

        public Builder WithTitle(string title)
        {
            return this;
        }

        public Builder WithDestination(string from, string to)
        {
            return this;
        }

        public Builder WithDistance(double distance, string dimension)
        {
            return this;
        }

        public Builder WithEstimatedTime(TimeSpan estimatedTime)
        {
            return this;
        }

        public Builder WithPrice(double value, string currency)
        {
            return this;
        }

        public DomainResult<Route> Build()
        {
            return DomainResult<Route>.Ok(_route);
        }
    }
}