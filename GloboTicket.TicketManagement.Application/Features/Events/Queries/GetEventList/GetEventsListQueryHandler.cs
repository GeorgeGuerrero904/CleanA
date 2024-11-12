using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventList
{
    public class GetEventsListQueryHandler : IRequestHandler<GetEventsListsQuery, List<EventListVm>>
    {
        public Task<List<EventListVm>> Handle(GetEventsListsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
