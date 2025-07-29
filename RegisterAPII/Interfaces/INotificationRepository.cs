using RegisterAPII.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace RegisterAPII.Interfaces
{
    public interface INotificationRepository
    {
        Task<List<NotificationCrud>> GetAllNotificationsAsync();
        Task<NotificationCrud> GetNotificationByIdAsync(int id);
        Task AddNotificationAsync(NotificationCrud notification);

        Task<bool> MarkAsReadAsync(int id);

        Task UpdateNotificationAsync(NotificationCrud notification);
        Task DeleteNotificationAsync(int id);

    }
}