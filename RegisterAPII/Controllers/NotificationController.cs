using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegisterAPII.Interfaces;
using RegisterAPII.Models;

namespace RegisterAPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationRepository _notificationRepository;

        // The controller "asks" for an INotificationRepository here.
        public NotificationController(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllNotifications()
        {
            var notifications = await _notificationRepository.GetAllNotificationsAsync();
            return Ok(notifications);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNotificationById(int id)
        {
            var notification = await _notificationRepository.GetNotificationByIdAsync(id);

            if (notification == null)
            {
                return NotFound();
            }

            return Ok(notification);
        }

        [HttpPost]
        public async Task<IActionResult> AddNotification([FromBody] NotificationCrud notification)
        {
            await _notificationRepository.AddNotificationAsync(notification);
            return Ok(new { message = "Notification added successfully." });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNotification(int id, [FromBody] NotificationCrud notification)
        {
            if (id != notification.Id)
            {
                return BadRequest("ID in URL does not match ID in notification object");
            }

            await _notificationRepository.UpdateNotificationAsync(notification);
            return Ok(new { message = "Notification updated successfully." });
        }

        [HttpPut("{id}/read")] // e.g., PUT /api/Notification/5/read
        public async Task<IActionResult> MarkNotificationAsRead(int id)
        {
            // Update the repository method call to avoid assigning void to a variable  
            var notificationExists = await _notificationRepository.GetNotificationByIdAsync(id) != null;

            if (!notificationExists)
            {
                return NotFound(new { Message = "Notification not found." });
            }

            await _notificationRepository.MarkAsReadAsync(id);
            return NoContent(); // Success  
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotification(int id)
        {
            await _notificationRepository.DeleteNotificationAsync(id);
            return Ok(new { message = "Notification deleted successfully." });
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegisterAPII.Interfaces;
using RegisterAPII.Models;

namespace RegisterAPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationRepository _notificationRepository;

        // The controller "asks" for an INotificationRepository here.
        public NotificationController(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllNotifications()
        {
            var notifications = await _notificationRepository.GetAllNotificationsAsync();
            return Ok(notifications);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNotificationById(int id)
        {
            var notification = await _notificationRepository.GetNotificationByIdAsync(id);

            if (notification == null)
            {
                return NotFound();
            }

            return Ok(notification);
        }

        [HttpPost]
        public async Task<IActionResult> AddNotification([FromBody] NotificationCrud notification)
        {
            await _notificationRepository.AddNotificationAsync(notification);
            return Ok(new { message = "Notification added successfully." });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNotification(int id, [FromBody] NotificationCrud notification)
        {
            if (id != notification.Id)
            {
                return BadRequest("ID in URL does not match ID in notification object");
            }

            await _notificationRepository.UpdateNotificationAsync(notification);
            return Ok(new { message = "Notification updated successfully." });
        }

        [HttpPut("{id}/read")] // e.g., PUT /api/Notification/5/read
        public async Task<IActionResult> MarkNotificationAsRead(int id)
        {
            // Update the repository method call to avoid assigning void to a variable  
            var notificationExists = await _notificationRepository.GetNotificationByIdAsync(id) != null;

            if (!notificationExists)
            {
                return NotFound(new { Message = "Notification not found." });
            }

            await _notificationRepository.MarkAsReadAsync(id);
            return NoContent(); // Success  
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotification(int id)
        {
            await _notificationRepository.DeleteNotificationAsync(id);
            return Ok(new { message = "Notification deleted successfully." });
        }
    }
}
