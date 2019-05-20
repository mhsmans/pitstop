using Pitstop.Infrastructure.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pitstop.Application.BaggageSetManagement.Events
{
    public class BaggageLoadedOnToFlight : Event
    {
        public readonly string ScheduledFlightId;

        public BaggageLoadedOnToFlight(Guid messageId, string scheduledFlightId) : base(messageId)
        {
            ScheduledFlightId = scheduledFlightId;
        }
    }
}
