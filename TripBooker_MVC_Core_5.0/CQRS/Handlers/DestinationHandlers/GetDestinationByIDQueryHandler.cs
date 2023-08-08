using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripBooker_MVC_Core_5._0.CQRS.Queries.DestinationQueries;
using TripBooker_MVC_Core_5._0.CQRS.Results.DestinationResults;

namespace TripBooker_MVC_Core_5._0.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;
        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIDQueryResult
            {
                DestinationID = values.DestinationID,
                City = values.City,
                DayNight = values.DayNight,
                Price = values.Price
            };
        }
    }
}