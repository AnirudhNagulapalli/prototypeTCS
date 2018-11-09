using System;
using System.Collections.Generic;

namespace nani.Models
{
    public partial class Train100rows
    {
        public string Id { get; set; }
        public int? VendorId { get; set; }
        public string PickupDatetime { get; set; }
        public string DropoffDatetime { get; set; }
        public string PassengerCount { get; set; }
        public double? PickupLongitude { get; set; }
        public double? PickupLatitude { get; set; }
        public double? DropoffLongitude { get; set; }
        public double? DropoffLatitude { get; set; }
        public string StoreAndFwdFlag { get; set; }
        public int? TripDuration { get; set; }
    }
}
