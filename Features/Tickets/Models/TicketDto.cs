using Microsoft.VisualBasic;

namespace CloudZen.Features.Tickets.Models
{
    public class TicketDto
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public bool IsOpen { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? Summary { get; set; }
    }
}