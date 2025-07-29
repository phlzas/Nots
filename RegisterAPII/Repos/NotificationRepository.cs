using Microsoft.EntityFrameworkCore;
using RegisterAPII.DATA;
using RegisterAPII.DTOs;
using RegisterAPII.Interfaces;
using RegisterAPII.Models;
using System.Text.Json;

namespace RegisterAPII.Repos
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly ApplicationDbContext _context;
        public NotificationRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<NotificationCrud>> GetAllNotificationsAsync()
        {
            var notifications = await _context.NotificationCruds.ToListAsync();
            return notifications;
        }

        public async Task<NotificationCrud> GetNotificationByIdAsync(int id)
        {
            var notification = await _context.NotificationCruds.FindAsync(id);
            return notification;
        }

        public async Task AddNotificationAsync(NotificationCrud notification)
        {

            _context.NotificationCruds.Add(notification);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateNotificationAsync(NotificationCrud notification)
        {
            // Fetch the existing notification from your data source (e.g., database)
            var existingNotification = await _context.NotificationCruds.FindAsync(notification.Id);
            if (existingNotification != null)
            {
                existingNotification.Title = notification.Title;
                existingNotification.Descreption = notification.Descreption;
                existingNotification.Role = notification.Role;
                existingNotification.Date = notification.Date;

                // Set IsRidden to true when updating
                existingNotification.IsRidden = notification.IsRidden;

                await _context.SaveChangesAsync();
            }

        }


        public async Task DeleteNotificationAsync(int id)
        {
            var notification = await _context.NotificationCruds.FindAsync(id);
            if (notification != null)
            {
                _context.NotificationCruds.Remove(notification);
                await _context.SaveChangesAsync();
            }
        }


        public async Task<bool> MarkAsReadAsync(int notificationId)
        {
            // 1. Find the notification in the database by its ID
            var notification = await _context.NotificationCruds.FindAsync(notificationId);

            // 2. Check if it was found
            if (notification == null)
            {
                return false; // Not found, so we can't update it
            }

            // 3. Update the property
            notification.IsRidden = true;

            // 4. THIS IS THE MOST IMPORTANT LINE: Save the changes to the database.
            // Without this, the change is never made permanent.
            await _context.SaveChangesAsync();

            return true; // Success!
        }
    }
}