// --- File: src/pages/StaffDashboard.js (Updated) ---

import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom"; // 1. Import useNavigate

// Import necessary icons
import { IoOptionsOutline, IoAddCircleOutline } from "react-icons/io5"; // 2. Import a new icon for the button

// Import reusable components
import AdminSidebar from "./components/AdminSidebar";
import AdminHeader from "./components/AdminHeader";

// Import staff service
import { staffService } from "../services/staffService";

// Import CSS
import "./StudentDashboard.css";
import "./StaffDashboard.css";

const StaffDashboard = () => {
  const navigate = useNavigate(); // 3. Initialize the navigate function

  // State for staff data and loading
  const [staffData, setStaffData] = useState([]);
  const [stats, setStats] = useState({
    total: 0,
    present: 0,
    late: 0,
    absent: 0,
  });
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  // Fetch staff data on component mount
  useEffect(() => {
    fetchStaffData();
  }, []);

  const fetchStaffData = async () => {
    try {
      setLoading(true);
      const report = await staffService.getDailyReport();

      // Transform backend data to match frontend format
      const transformedData = report.attendanceDetails.map((staff) => ({
        id: staff.id,
        name: staff.employeeName,
        department: staff.department,
        status: staff.status,
        checkInTime: staff.checkInTime
          ? new Date(staff.checkInTime).toLocaleTimeString("en-US", {
              hour: "2-digit",
              minute: "2-digit",
              hour12: false,
            })
          : "—",
        method: staff.checkInMethod === "N/A" ? "—" : staff.checkInMethod,
      }));

      setStaffData(transformedData);
      setStats({
        total: report.totalStaff,
        present: report.present,
        late: report.late,
        absent: report.absent,
      });
      setError(null);
    } catch (err) {
      console.error("Error fetching staff data:", err);
      setError("Failed to load staff data. Please try again.");
      // Fallback to mock data if API fails
      setStaffData([
        {
          id: 1,
          name: "Ahmed Mohamed",
          department: "Engineering",
          status: "Present",
          checkInTime: "08:45",
          method: "Face ID",
        },
        {
          id: 2,
          name: "Fatima Ali",
          department: "Human Resources",
          status: "Absent",
          checkInTime: "—",
          method: "—",
        },
        {
          id: 3,
          name: "Mohamed Mohsen",
          department: "Finance",
          status: "Present",
          checkInTime: "09:00",
          method: "Face ID",
        },
        {
          id: 4,
          name: "Aliaa Hussein",
          department: "Marketing",
          status: "Late",
          checkInTime: "09:15",
          method: "Fingerprint",
        },
      ]);
      setStats({ total: 245, present: 198, late: 12, absent: 47 });
    } finally {
      setLoading(false);
    }
  };

  if (loading) {
    return (
      <div className="dashboard-layout">
        <AdminSidebar />
        <main className="main-content">
          <AdminHeader />
          <section className="content-area">
            <div
              className="loading-container"
              style={{ textAlign: "center", padding: "50px" }}
            >
              <p>Loading staff data...</p>
            </div>
          </section>
        </main>
      </div>
    );
  }

  return (
    <div className="dashboard-layout">
      <AdminSidebar />
      <main className="main-content">
        <AdminHeader />
        <section className="content-area">
          {/* Error message */}
          {error && (
            <div
              className="error-message"
              style={{
                backgroundColor: "#f8d7da",
                color: "#721c24",
                padding: "10px",
                borderRadius: "5px",
                marginBottom: "20px",
                border: "1px solid #f5c6cb",
              }}
            >
              {error}
              <button
                onClick={fetchStaffData}
                style={{
                  marginLeft: "10px",
                  padding: "5px 10px",
                  backgroundColor: "#721c24",
                  color: "white",
                  border: "none",
                  borderRadius: "3px",
                  cursor: "pointer",
                }}
              >
                Retry
              </button>
            </div>
          )}

          {/* --- 4. THIS HEADER SECTION IS MODIFIED --- */}
          <div className="content-header">
            <h2>Staff Attendance Overview</h2>
            <div className="header-actions-group">
              <button
                className="add-staff-btn"
                onClick={() => navigate("/register")}
              >
                <IoAddCircleOutline />
                Add New Staff
              </button>
              <button
                className="refresh-btn"
                onClick={fetchStaffData}
                style={{
                  marginRight: "10px",
                  padding: "8px 12px",
                  backgroundColor: "#007bff",
                  color: "white",
                  border: "none",
                  borderRadius: "5px",
                  cursor: "pointer",
                }}
              >
                Refresh
              </button>
              <IoOptionsOutline className="filter-icon" />
            </div>
          </div>

          {/* Stats Grid (unchanged) */}
          <div className="stats-grid">
            <div className="card stat-card">
              <p className="stat-value">{stats.total}</p>
              <p className="stat-label">Total Staff</p>
            </div>
            <div className="card stat-card">
              <p className="stat-value" style={{ color: "#28a745" }}>
                {stats.present}
              </p>
              <p className="stat-label">Present Today</p>
            </div>
            <div className="card stat-card">
              <p className="stat-value" style={{ color: "#E60028" }}>
                {stats.absent}
              </p>
              <p className="stat-label">Absent Today</p>
            </div>
            <div className="card stat-card">
              <p className="stat-value" style={{ color: "#ffc107" }}>
                {stats.late}
              </p>
              <p className="stat-label">Late Today</p>
            </div>
          </div>

          {/* Attendance Table (unchanged) */}
          <div className="attendance-table-container card">
            <div className="content-header">
              <h3>Today's Attendance Status</h3>
            </div>
            <div className="table-responsive">
              <table className="attendance-table">
                <thead>
                  <tr>
                    <th>Employee Name</th>
                    <th>Department</th>
                    <th>Status</th>
                    <th>Check-in Time</th>
                    <th>Method</th>
                  </tr>
                </thead>
                <tbody>
                  {staffData.length > 0 ? (
                    staffData.map((staff) => (
                      <tr key={staff.id}>
                        <td data-label="Employee Name">{staff.name}</td>
                        <td data-label="Department">{staff.department}</td>
                        <td data-label="Status">
                          <span
                            className={`status-tag status-${staff.status.toLowerCase()}`}
                          >
                            {staff.status}
                          </span>
                        </td>
                        <td data-label="Check-in Time">{staff.checkInTime}</td>
                        <td data-label="Method">{staff.method}</td>
                      </tr>
                    ))
                  ) : (
                    <tr>
                      <td
                        colSpan="5"
                        style={{ textAlign: "center", padding: "20px" }}
                      >
                        No staff attendance data available for today.
                      </td>
                    </tr>
                  )}
                </tbody>
              </table>
            </div>
          </div>
        </section>
      </main>
    </div>
  );
};

export default StaffDashboard;
