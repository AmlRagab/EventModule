using EventModule.Models;
using EventModule.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EventModule.Features.Events.Queries
{
    public class GetEventByIdQuery:IRequest<Event>
    {
        public int Id { get; set; }

        public class GetEventByIdQueryHandler : IRequestHandler<GetEventByIdQuery, Event>
        {
            private readonly IEvents _eventService;

            public GetEventByIdQueryHandler(IEvents eventService)
            {
                _eventService = eventService;
            }

           

            public async Task<Event> Handle(GetEventByIdQuery request, CancellationToken cancellationToken)
            {
                return await _eventService.GetEventById(request.Id);
            }
        }
    }
}
