using Pitstop.Infrastructure.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pitstop.Application.BaggageSetManagement.Commands
{
    public class LoadBaggageOnFlight : Command
    {
        public readonly string ScheduledFlightId;

        public LoadBaggageOnFlight(Guid messageId, string scheduledFlightId) : base(messageId)
        {
            ScheduledFlightId = scheduledFlightId;
        }
    }
}