using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventModule.Models;
using System.Threading;
using EventModule.Services;

namespace EventModule.Features.Events.Queries
{
    public class GetAllEventsQuery : IRequest<IEnumerable<Event>>
    {
        public class GetAllPlayersQueryHandler : IRequestHandler<GetAllEventsQuery, IEnumerable<Event>>
        {
            private readonly IEvents _eventService;

            public GetAllPlayersQueryHandler(IEvents eventService)
            {
                _eventService = eventService;
            }

            public async Task<IEnumerable<Event>> Handle(GetAllEventsQuery query, CancellationToken cancellationToken)
            {
                return await _eventService.GetEventsList();
            }
        }
    }
}

