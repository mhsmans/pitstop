using Pitstop.Infrastructure.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pitstop.Application.BaggageSetManagement.Commands
{
    public class RegisterBaggageSet : Command
    {
        public readonly string ScheduledFlightId;
        public readonly string BaggageClaimId;

        public RegisterBaggageSet(Guid messageId, string scheduledFlightId, string baggageClaimId) : base(messageId)
        {
            ScheduledFlightId = scheduledFlightId;
            BaggageClaimId = baggageClaimId;
        }
    }
}
