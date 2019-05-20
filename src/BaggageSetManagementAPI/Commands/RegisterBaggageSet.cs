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
        public readonly Boolean LoadedOnToFlight;
        public readonly Boolean DeliveredToBaggageClaim;

        public RegisterBaggageSet(Guid messageId, string scheduledFlightId, string baggageClaimId, Boolean loadedOnToFlight,
        Boolean deliveredToBaggageClaim) : base(messageId)
        {
            ScheduledFlightId = scheduledFlightId;
            BaggageClaimId = baggageClaimId;
            LoadedOnToFlight = loadedOnToFlight;
            DeliveredToBaggageClaim = deliveredToBaggageClaim;
        }
    }
}
