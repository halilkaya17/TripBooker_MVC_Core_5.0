using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripBooker_MVC_Core_5._0.CQRS.Queries.DestinationQueries;
using TripBooker_MVC_Core_5._0.CQRS.Results.DestinationResults;

namespace TripBooker_MVC_Core_5._0.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;
        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                id = x.DestinationID,
                capacity = x.Capacity,
                city = x.City,
                daynight = x.DayNight,
                price = x.Price
            }).AsNoTracking().ToList();
            return values;
        }
    }
}