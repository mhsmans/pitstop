using System;

namespace Pitstop.Application.BaggageSetManagement.Model
{
    public class BaggageSet
    {
        public string BaggageClaimId { get; set; }
        public string ScheduledFlightId { get; set; }
        public Boolean LoadedOnFlight { get; set; }
        public Boolean DeliveredToBaggageClaim { get; set; }
    }
}