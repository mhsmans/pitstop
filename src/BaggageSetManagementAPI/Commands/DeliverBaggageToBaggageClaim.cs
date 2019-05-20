using Pitstop.Infrastructure.Messaging;
using System;
using System.Collections.Generic;
using System.Text;


namespace Pitstop.Application.BaggageSetManagement.Commands
{
    public class DeliverBaggageToBaggageClaim : Command
    {
        public readonly string ScheduledFlightId;

        public DeliverBaggageToBaggageClaim(Guid messageId, string scheduledFlightId) : base(messageId)
        {
            ScheduledFlightId = scheduledFlightId;
        }
    }
}