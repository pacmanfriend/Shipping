using Shipping.Domain.Common.ValueObjects;
using Shipping.Domain.Route.ValueObjects;

namespace Shipping.Domain.Route;

public class Route
{
    public EntityId Id { get; private set; }
    public RouteTitle Title { get; private set; }
    public CityName From { get; private set; }
    public CityName To { get; private set; }
    public TimeSpan EstimatedTime { get; private set; }
    public RouteDistance RouteDistance { get; private set; }
    public Price BasePrice { get; private set; }

    public Route()
    {
    }

    public class Builder
    {
        private readonly Route _route = new Route();

        public Builder WithEmptyId()
        {
            var entityId = EntityId.FromGuid(Guid.Empty);

            _route.Id = entityId;

            return this;
        }

        public Builder WithExitingId(Guid id)
        {
            var entityId = EntityId.FromGuid(id);
            _route.Id = entityId;

            return this;
        }

        public Builder WithNewId()
        {
            var entityId = EntityId.FromGuid(Guid.NewGuid());
            _route.Id = entityId;

            return this;
        }

        public Builder WithTitle(string title)
        {
            var routeTitle = RouteTitle.New(title);

            _route.Title = routeTitle;

            return this;
        }

        public Builder WithDestination(string from, string to)
        {
            var cityFrom = CityName.New(from);
            var cityTo = CityName.New(to);

            _route.From = cityFrom;
            _route.To = cityTo;

            return this;
        }

        public Builder WithDistance(double distance, string dimension)
        {
            var routeDistance = RouteDistance.FromKilometers(distance);

            _route.RouteDistance = routeDistance;

            return this;
        }

        public Builder WithEstimatedTime(string time)
        {
            var t = TimeSpan.Parse(time);

            _route.EstimatedTime = t;
            return this;
        }

        public Builder WithPrice(double value, string currency)
        {
            var price = Price.FromRub(value);

            _route.BasePrice = price;

            return this;
        }

        public Route Build()
        {
            return _route;
        }
    }
}