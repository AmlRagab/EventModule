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
    public class UpdateEventCommand : IRequest<int>
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
        public int EventId { get; set; }
        public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand, int>
        {
            private readonly IEvents _eventService;

            public UpdateEventCommandHandler(IEvents eventService)
            {
                _eventService = eventService;
            }

            public async Task<int> Handle(UpdateEventCommand command, CancellationToken cancellationToken)
            {
                var _event = await _eventService.GetEventById(command.EventId);
                if (_event == null)
                    return default;

                _event.ArabicTitle = command.ArabicTitle;
                _event.EnglishTilte = command.EnglishTilte;
                _event.StartDate = command.StartDate;
                _event.EndDate = command.EndDate;
                _event.Content = command.Content;
                _event.Address = command.Address;
                _event.AlbumId = command.AlbumId;
                _event.SourceId = command.SourceId;
                _event.CoverPhoto = command.CoverPhoto;

                return await _eventService.UpdateEvent(_event);
            }
        }
    }
}
