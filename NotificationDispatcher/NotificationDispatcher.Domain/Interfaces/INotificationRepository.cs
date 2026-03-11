using NotificationDispatcher.Domain.Entities;

namespace NotificationDispatcher.Domain.Interfaces
{
    public interface INotificationRepository
    {
        Task AddAsync(Notification notification);
        Task<Notification?> GetByIdAsync(Guid id);
        Task<IEnumerable<Notification>> GetPendingAsync();
        Task UpdateAsync(Notification notification);
    }
}
