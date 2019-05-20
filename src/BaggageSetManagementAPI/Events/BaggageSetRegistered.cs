using Pitstop.Infrastructure.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pitstop.Application.BaggageSetManagement.Events
{
    public class BaggageSetRegistered : Event
    {
        public readonly string ScheduledFlightId;
        public readonly string BaggageClaimId;
        public readonly Boolean LoadedOnToFlight;
        public readonly Boolean DeliveredToBaggageClaim;


        public BaggageSetRegistered(Guid messageId, string scheduledFlightId, string baggageClaimId, Boolean loadedOnToFlight,
        Boolean deliveredToBaggageClaim) : base(messageId)
        {
            ScheduledFlightId = scheduledFlightId;
            BaggageClaimId = baggageClaimId;
            LoadedOnToFlight = loadedOnToFlight;
            DeliveredToBaggageClaim = deliveredToBaggageClaim;
        }
    }
}
