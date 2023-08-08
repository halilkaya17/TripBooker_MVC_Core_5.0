using DataAccessLayer.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TripBooker_MVC_Core_5._0.CQRS.Queries.GuideQueries;
using TripBooker_MVC_Core_5._0.CQRS.Results.GuideResults;

namespace TripBooker_MVC_Core_5._0.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIDQueryHandler : IRequestHandler<GetGuideByIDQuery, GetGuideByIDQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIDQueryResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIDQueryResult
            {
                GuideID = values.GuideID,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}