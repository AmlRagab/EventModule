using EventModule.Models;
using EventModule.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EventModule.Features.Events.Commands
{
    public class DeleteEventCommand : IRequest<int>
    {
            public int Id { get; set; }

            public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand, int>
            {
            private readonly IEvents _eventService;

            public DeleteEventCommandHandler(IEvents eventService)
            {
                _eventService = eventService;
            }

            public async Task<int> Handle(DeleteEventCommand command, CancellationToken cancellationToken)
                {
                    var _event = await _eventService.GetEventById(command.Id);
                    if (_event == null)
                        return default;

                    return await _eventService.DeleteEvent(_event);
                }
            }
        }
    }

