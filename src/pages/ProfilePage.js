import React, { useState, useEffect, useCallback } from 'react';
import { useNavigate, Link } from 'react-router-dom';
import api from '../services/api'; // Assuming 'api' is your configured axios instance
import './ProfilePage.css';
import {
  FiEdit,
  FiLogOut,
  FiArrowLeft,
  FiPhone,
  FiAward,
  FiHash,
  FiCalendar,
  FiMapPin,
  FiGlobe,
  FiSave,
  FiTrash2,
  FiX,
  FiAlertTriangle
} from 'react-icons/fi';

// (EditModal, LogoutConfirmModal, and NoteCard components go here, unchanged from the final version below)
// ...

/* ------------------------------------------------------------------
 * Main Profile Page Component
 * ------------------------------------------------------------------ */
const ProfilePage = () => {
  // --- State Management ---
  const [user, setUser] = useState(null);
  const [isLoading, setIsLoading] = useState(true);
  const [error, setError] = useState('');
  const [isEditModalOpen, setEditModalOpen] = useState(false);
  const [isLogoutModalOpen, setLogoutModalOpen] = useState(false);
  const navigate = useNavigate();

  // --- Data Fetching ---
  // Central function to fetch user data, wrapped in useCallback for performance.
  // This prevents it from being recreated on every render.
  const fetchFullProfile = useCallback(async (userId) => {
    setIsLoading(true);
    setError('');
    try {
      const response = await api.get(`/api/StudentProfile/${userId}`);
      setUser(response.data);
      localStorage.setItem('user', JSON.stringify(response.data)); // Keep localStorage in sync
    } catch (err) {
      console.error('Fetch Profile Error:', err.response || err);
      setError('Could not load your profile. Please try logging in again.');
      setUser(null); // Clear user data on critical fetch error
      localStorage.removeItem('user');
    } finally {
      setIsLoading(false);
    }
  }, []);

  // --- Effects ---
  // On component mount, get user ID from localStorage and fetch the profile.
  useEffect(() => {
    const userString = localStorage.getItem('user');
    if (userString) {
      const storedUser = JSON.parse(userString);
      if (storedUser && storedUser.id) {
        fetchFullProfile(storedUser.id);
      } else {
        navigate('/');
      }
    } else {
      navigate('/');
    }
  }, [navigate, fetchFullProfile]);

  // --- Event Handlers ---
  const handleLogout = () => {
    localStorage.clear();
    navigate('/');
  };

  // Called from the modal after a successful PUT request.
  // Re-fetches data to ensure UI has the latest information.
  const handleProfileUpdate = (userId) => {
    fetchFullProfile(userId);
  };

  // Passed to the modal to handle the delete API call.
  const handleProfileDelete = async (userId) => {
    // This function now returns a promise that resolves or rejects,
    // allowing the modal to handle its own loading and error states.
    try {
      await api.delete(`/api/StudentProfile/${userId}`);
      handleLogout(); // On success, log out and redirect
    } catch (err) {
      console.error('Delete Profile Error:', err.response || err);
      // Re-throw the error so the modal's catch block can handle it
      throw new Error('Failed to delete the profile.');
    }
  };

  // --- Child Components ---
  const InfoDetail = ({ Icon, label, value }) => (
    <div className="info-detail">
      <Icon className="info-icon" />
      <div className="info-text">
        <span className="info-label">{label}</span>
        <span className="info-value">{value ?? 'N/A'}</span>
      </div>
    </div>
  );

  // --- Render Logic ---
  if (isLoading) {
    return <div className="loading-container">Loading Profile...</div>;
  }

  if (error || !user) {
    return (
      <div className="loading-container">
        {error}{' '}
        <button className="action-btn secondary" onClick={handleLogout}>Login</button>
      </div>
    );
  }

  if (user.classId >= 1 && user.classId <= 4) {
    user.grade = 'Junior';
  } else if (user.classId >= 5 && user.classId <= 8) {
    user.grade = 'Wheeler';
  } else if (user.classId >= 9 && user.classId <= 12) {
    user.grade = 'Senior';
  }

  const goodNotes = user.goodNotes || ['Listen carefully', 'Raise hand to speak', 'Respect others'];
  const badNotes = user.badNotes || ['Talk during class', 'Use phone', 'Interrupt others'];

  return (
    <div className="profile-page-container">
      <div className="profile-wrapper">
        <Link to={user.role === 'admin' ? '/dashboard' : '/student-dashboard'} className="back-link">
          <FiArrowLeft /> Back to Dashboard
        </Link>

        <div className="profile-content-card">
          {/* Sidebar */}
          <div className="profile-sidebar">
            <img
              src={
                user.imageP ||
                `https://ui-avatars.com/api/?name=${encodeURIComponent(user.name)}&background=d90429&color=fff&size=128&bold=true`
              }
              alt="Profile"
              className="profile-avatar"
            />
            <h2 className="profile-name">{user.name}</h2>
            <p className="profile-email">{user.email}</p>
            <div className="profile-actions">
              <button onClick={() => setEditModalOpen(true)} className="action-btn primary">
                <FiEdit /> Edit Profile
              </button>
              <button onClick={() => setLogoutModalOpen(true)} className="action-btn secondary">
                <FiLogOut /> Log out
              </button>
            </div>
          </div>

          {/* Main Content */}
          <div className="profile-main-content">
            <div className="info-section">
              <h4>Account Details</h4>
              <div className="details-grid">
                <InfoDetail Icon={FiPhone} label="Phone Number" value={user.phoneNumber} />
                <InfoDetail Icon={FiAward} label="Grade" value={user.grade} />
                <InfoDetail Icon={FiHash} label="Age" value={user.age} />
                <InfoDetail Icon={FiCalendar} label="Days Absent" value={user.daysAbsent || 0} />
              </div>
            </div>

            <div className="info-section">
              <h4>Location Information</h4>
              <div className="details-grid">
                <InfoDetail Icon={FiMapPin} label="Location / City" value={user.city} />
                <InfoDetail Icon={FiGlobe} label="Country" value={user.country} />
              </div>
            </div>

            <div className="notes-section">
              <NoteCard variant="good" title="Good Notes" notes={goodNotes} />
              <NoteCard variant="bad" title="Bad Notes" notes={badNotes} />
            </div>

            <div className="privacy-notice">
              <p>This information is private and will not be shared.</p>
            </div>
          </div>
        </div>
      </div>

      {isEditModalOpen && (
        <EditModal
          user={user}
          onClose={() => setEditModalOpen(false)}
          onSaveSuccess={handleProfileUpdate}
          onDelete={handleProfileDelete}
        />
      )}

      {isLogoutModalOpen && (
        <LogoutConfirmModal
          name={user.name}
          onCancel={() => setLogoutModalOpen(false)}
          onConfirm={handleLogout}
        />
      )}
    </div>
  );
};

/* ------------------------------------------------------------------
 * Edit Profile Modal
 * ------------------------------------------------------------------ */
const EditModal = ({ user, onClose, onSaveSuccess, onDelete }) => {
  const [editableUser, setEditableUser] = useState(user);
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState('');

  const handleInputChange = (e) => {
    const { name, value, type } = e.target;
    // Ensure number inputs are stored as numbers or empty strings
    const processedValue =
      type === 'number' ? (value === '' ? '' : parseInt(value, 10)) : value;
    setEditableUser((prev) => ({ ...prev, [name]: processedValue }));
  };

  const handleSaveChanges = async () => {
    setIsLoading(true);
    setError('');
    try {
      await api.put(`/api/StudentProfile/${editableUser.id}`, editableUser);
      onSaveSuccess(editableUser.id); // Trigger re-fetch on parent
      onClose(); // Close modal on success
    } catch (err) {
      console.error('Update Error:', err.response || err);
      const message = err.response?.data?.title || 'Failed to update profile.';
      setError(`${message} Please check your inputs and try again.`);
    } finally {
      setIsLoading(false);
    }
  };

  const handleDelete = async () => {
    if (window.confirm('Are you sure you want to permanently delete your profile?')) {
      setIsLoading(true);
      setError('');
      try {
        // The onDelete function passed from the parent handles the API call and redirection
        await onDelete(user.id);
        // No need to do anything else, as the parent will redirect
      } catch (err) {
        // If the parent's onDelete fails, show the error here
        setError(err.message);
        setIsLoading(false);
      }
    }
  };

  return (
    <div className="modal-overlay">
      <div className="modal-content">
        <div className="modal-header">
          <h2>Edit Profile</h2>
          <button onClick={onClose} className="modal-close-btn">
            <FiX />
          </button>
        </div>

        {error && (
          <p className="modal-error">
            <FiAlertTriangle /> {error}
          </p>
        )}

        <div className="modal-body">
          {/* Input fields remain the same */}
          <div className="modal-input-group full-width">
            <label>Full Name</label>
            <input
              type="text"
              name="name"
              value={editableUser.name || ''}
              onChange={handleInputChange}
            />
          </div>
          <div className="modal-input-group full-width">
            <label>Profile Image URL</label>
            <input
              type="text"
              name="imageP"
              value={editableUser.imageP || ''}
              onChange={handleInputChange}
            />
          </div>
          <div className="modal-input-group">
            <label>Phone Number</label>
            <input
              type="text"
              name="phoneNumber"
              value={editableUser.phoneNumber || ''}
              onChange={handleInputChange}
            />
          </div>
          <div className="modal-input-group">
            <label>Age</label>
            <input
              type="number"
              name="age"
              value={editableUser.age || ''}
              onChange={handleInputChange}
            />
          </div>
          <div className="modal-input-group">
            <label>Location / City</label>
            <input
              type="text"
              name="city"
              value={editableUser.city || ''}
              onChange={handleInputChange}
            />
          </div>
          <div className="modal-input-group">
            <label>Country</label>
            <input
              type="text"
              name="country"
              value={editableUser.country || ''}
              onChange={handleInputChange}
            />
          </div>
        </div>

        <div className="modal-footer">
          <button onClick={handleDelete} className="modal-btn delete" disabled={isLoading}>
            <FiTrash2 /> Delete
          </button>
          <button onClick={handleSaveChanges} className="modal-btn save" disabled={isLoading}>
            {isLoading ? 'Saving...' : <><FiSave /> Save Changes</>}
          </button>
        </div>
      </div>
    </div>
  );
};

/* ------------------------------------------------------------------
 * Logout Confirmation Modal (Unchanged)
 * ------------------------------------------------------------------ */
const LogoutConfirmModal = ({ name, onCancel, onConfirm }) => (
  <div className="modal-overlay">
    <div className="logout-modal-content">
      <div className="logout-modal-icon">!</div>
      <h3 className="logout-modal-title">Log Out</h3>
      <p className="logout-modal-text">Are you sure you want to log out?</p>
      {name && <p className="logout-modal-user">{name}</p>}
      <div className="logout-modal-actions">
        <button type="button" className="logout-modal-btn cancel" onClick={onCancel}>
          Cancel
        </button>
        <button type="button" className="logout-modal-btn confirm" onClick={onConfirm}>
          Log Out
        </button>
      </div>
    </div>
  </div>
);

/* ------------------------------------------------------------------
 * NoteCard Component (Unchanged)
 * ------------------------------------------------------------------ */
const NoteCard = ({ variant, title, notes }) => (
  <div className={`note-card ${variant}`}>
    <div className="note-card-header">{title}</div>
    <ul className="note-card-list">
      {notes && notes.length > 0 ? (
        notes.map((n, i) => <li key={i}>{n}</li>)
      ) : (
        <li>No notes yet.</li>
      )}
    </ul>
  </div>
);

export default ProfilePage;