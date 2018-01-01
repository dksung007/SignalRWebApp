using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SignalRWebApp.Models
{
    [Serializable]
    [DataContract(IsReference =true)]
    public class FlightBookings : EntityBase
    {
        [DataMember]
        [Display(Name = "Flight ID")]
        public Int32 FlightId { get; set; }

        [DataMember]
        [Display(Name = "From")]
        public String From { get; set; }

        [DataMember]
        [Display(Name = "To")]
        public string TO { get; set; }

        [DataMember]
        [Display(Name = "SeatsAvailability")]
        public int SeatsAvailability { get; set; }

    }
}