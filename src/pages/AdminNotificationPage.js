// --- File: AdminNotificationPage.jsx (Fully Corrected) ---

import React, { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import {
  IoHomeOutline, IoDocumentTextOutline, IoPeopleOutline, IoSettingsOutline, IoNotificationsOutline,
  IoPersonAddOutline, IoServerOutline
} from 'react-icons/io5';
import dayjs from 'dayjs';
import isToday from 'dayjs/plugin/isToday';
import isYesterday from 'dayjs/plugin/isYesterday';

import './StudentDashboard.css';
import './StaffDashboard.css';
import './Notifications.css';

import logo from '../assets/logo.png';
import managerAvatar from '../assets/manger.png';
import api from '../services/api';

dayjs.extend(isToday);
dayjs.extend(isYesterday);

const AdminNotificationPage = () => {
  const navigate = useNavigate();
  const [notifications, setNotifications] = useState([]);
  const [filter, setFilter] = useState('all');
  const [selectedNotification, setSelectedNotification] = useState(null);
  const [showNotificationModal, setShowNotificationModal] = useState(false);

  useEffect(() => {
    const fetchNotifications = async () => {
      try {
        const response = await api.get('/api/Notification/all');
        const transformedNotifications = response.data.map(apiNotification => ({
          id: apiNotification.id,
          message: `${apiNotification.title}: ${apiNotification.descreption}`,
          type: apiNotification.role.toLowerCase().includes('report') ? 'report' : 'system',
          time: apiNotification.date,
          // Use 'unread' as the consistent property name inside the component
          unread: !apiNotification.isRidden
        }));
        setNotifications(transformedNotifications);
      } catch (err) {
        console.error("Failed to fetch notifications:", err);
      }
    };
    fetchNotifications();
  }, []);

  const handleNavigate = (path) => navigate(path);

  // --- THIS IS THE CORRECTED CLICK HANDLER ---
  const handleNotificationClick = async (notification) => {
    // Show the modal immediately for a good user experience
    setSelectedNotification(notification);
    setShowNotificationModal(true);

    // Only update if the notification is currently unread
    if (notification.unread) {
      // 1. Optimistic UI Update: Update the UI instantly.
      setNotifications(prev =>
        prev.map(n => (n.id === notification.id ? { ...n, unread: false } : n))
      );

      try {
        // 2. API Call: Tell the backend to save the change permanently.
        await api.put(`/api/Notification/${notification.id}/read`);
      } catch (error) {
        console.error('Failed to mark notification as read:', error);
        // Optional but recommended: If the API fails, revert the UI change
        setNotifications(prev =>
          prev.map(n => (n.id === notification.id ? { ...n, unread: true } : n))
        );
      }
    }
  };

  const getIcon = (type) => {
    switch (type) {
      case 'report': return <IoDocumentTextOutline />;
      case 'system': return <IoServerOutline />;
      default: return <IoPersonAddOutline />;
    }
  };

  const getTitle = (type) => {
    switch (type) {
      case 'report': return 'Report';
      case 'system': return 'System';
      default: return 'General';
    }
  };
  
  // --- CORRECTED THIS FUNCTION ---
  const groupNotificationsByDay = (notificationsList) => {
    const grouped = { Today: [], Yesterday: [], Earlier: [] };
    notificationsList.forEach(n => {
      // Use 'time' property, which is what you created in the transformation
      const date = dayjs(n.time); 
      if (date.isToday()) grouped.Today.push(n);
      else if (date.isYesterday()) grouped.Yesterday.push(n);
      else grouped.Earlier.push(n);
    });
    return grouped;
  };

  // --- CORRECTED THIS LOGIC ---
  const filteredNotifications = notifications.filter(n => {
    if (filter === 'unread') return n.unread; // Use the consistent 'unread' property
    return true;
  });

  const grouped = groupNotificationsByDay(filteredNotifications);

  return (
    <div className="dashboard-layout">
      {/* Sidebar and Header have no changes needed */}
      <aside className="sidebar">
        <div className="logo-container"><img src={logo} alt="Logo" className="logo" /></div>
        <div className="user-profile">
          <img src={managerAvatar} alt="Manager" className="profile-pic-small" />
          <div><p className="user-name">School Manager</p><p className="user-role">Administrator</p></div>
        </div>
        <nav className="nav-menu">
          <ul className="nav-submenu" style={{ margin: 0 }}>
            <li onClick={() => handleNavigate('/admin/dashboard')}><IoHomeOutline className="nav-icon" /> Dashboard</li>
            <li onClick={() => handleNavigate('/admin/reports')}><IoDocumentTextOutline className="nav-icon" /> Reports</li>
            <li onClick={() => handleNavigate('/admin/staff')}><IoPeopleOutline className="nav-icon" /> Staff List</li>
            <li onClick={() => handleNavigate('/admin/settings')}><IoSettingsOutline className="nav-icon" /> Settings</li>
          </ul>
        </nav>
      </aside>

      <main className="main-content">
        <header className="main-header">
          <div className="header-actions" style={{ marginLeft: 'auto' }}>
            <IoNotificationsOutline className="action-icon" />
            <div className="notification-dot"></div>
            <img src={managerAvatar} alt="Manager" className="profile-pic-header" onClick={() => navigate('/admin/profile')} />
            <div className="profile-dot"></div>
          </div>
        </header>

        <section className="content-area">
          <div className="content-header"><h2>Notifications</h2></div>

          <div className="notification-filters">
            <button
              onClick={() => setFilter('all')}
              className={`filter-button ${filter === 'all' ? 'active' : ''}`}
            >
              📰 All
            </button>
            <button
              onClick={() => setFilter('unread')}
              className={`filter-button ${filter === 'unread' ? 'active' : ''}`}
            >
              🔔 Unread
            </button>
          </div>

          {Object.entries(grouped).map(([day, items]) => (
            items.length > 0 && (
              <div key={day} style={{ marginBottom: '25px' }}>
                <h3 style={{ color: '#555', marginBottom: '10px' }}>{day}</h3>
                <ul className="notification-list">
                  {items.map(n => (
                    // --- CORRECTED THIS LOGIC ---
                    <li
                      key={n.id}
                      className={`notification-item ${n.unread ? 'unread' : ''}`}
                      onClick={() => handleNotificationClick(n)}
                    >
                      <div className={`notification-icon-container ${n.type}`}>{getIcon(n.type)}</div>
                      <div className="notification-content">
                        <p>{n.message}</p>
                        <span>{dayjs(n.time).format('HH:mm A')}</span>
                      </div>
                      {n.unread && <div className="notification-dot-indicator"></div>}
                    </li>
                  ))}
                </ul>
              </div>
            )
          ))}
        </section>
      </main>

      {/* Modal has no changes needed */}
      {showNotificationModal && selectedNotification && (
        <div className="modal-overlay" onClick={() => setShowNotificationModal(false)}>
          <div className="modal-content" onClick={(e) => e.stopPropagation()}>
            <div className="modal-icon">{getIcon(selectedNotification.type)}</div>
            <h2>{getTitle(selectedNotification.type)}</h2>
            <p>{selectedNotification.message}</p>
            <small>{dayjs(selectedNotification.time).format('DD MMM YYYY - HH:mm A')}</small>
            <br />
            <button onClick={() => setShowNotificationModal(false)}>Close</button>
          </div>
        </div>
      )}
    </div>
  );
};

export default AdminNotificationPage;