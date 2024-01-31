using System;
using System.Collections.Generic;

namespace DALLAYER.Models
{
    public partial class BusBookingDetail
    {
        public string BusId { get; set; } = null!;
        public string Username { get; set; } = null!;
        public int TicketId { get; set; }
        public string FullName { get; set; } = null!;
        public int Age { get; set; }
        public string ContactNumber { get; set; } = null!;
        public string EmailId { get; set; } = null!;
        public int NumberOfTickets { get; set; }
        public int TotalAmount { get; set; }
        public int Fare { get; set; }
        public string PaymentMode { get; set; } = null!;
        public string? PaymentStatus { get; set; }
        public string? TicketStatus { get; set; }
    }
}
