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
    public class CreateEventCommand : IRequest<Event>
    {
        public string ArabicTitle { get; set; }
        public string EnglishTilte { get; set; }
        public string Content { get; set; }
        public string Address { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte[] CoverPhoto { get; set; }
        public int? SourceId { get; set; }
        public int? AlbumId { get; set; }
        public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Event>
        {
            private readonly IEvents _eventService;

            public CreateEventCommandHandler(IEvents eventService)
            {
                _eventService = eventService;
            }


            public async Task<Event> Handle(CreateEventCommand command, CancellationToken cancellationToken)
            {
                var _Event = new Event()
                {
                    ArabicTitle = command.ArabicTitle,
                    EnglishTilte = command.EnglishTilte,
                    StartDate = command.StartDate,
                    EndDate = command.EndDate,
                    Content = command.Content,
                    Address = command.Address,
                    AlbumId = command.AlbumId,
                    SourceId = command.SourceId,
                    CoverPhoto = command.CoverPhoto,

                };

                return await _eventService.CreateEvent(_Event);
            }
        }
    }
}
