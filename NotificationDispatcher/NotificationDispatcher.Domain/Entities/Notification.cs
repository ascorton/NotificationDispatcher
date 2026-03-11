using NotificationDispatcher.Domain.Enums;

namespace NotificationDispatcher.Domain.Entities
{
    public class Notification
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Addressee { get; set; }
        public required string Message { get; set; }
        public MessageStatus Status { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.UtcNow;
    }
}
