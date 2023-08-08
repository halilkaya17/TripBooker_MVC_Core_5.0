using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripBooker_MVC_Core_5._0.CQRS.Results.GuideResults;

namespace TripBooker_MVC_Core_5._0.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery : IRequest<GetGuideByIDQueryResult>
    {
        public GetGuideByIDQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}