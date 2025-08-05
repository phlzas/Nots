// --- File: src/pages/components/SpecialistSidebar.js ---

import React, { useState } from "react";
import { useNavigate, useLocation } from "react-router-dom";
import {
  IoDocumentTextOutline,
  IoPersonOutline,
  IoLogOutOutline,
  IoMenuOutline,
  IoCloseOutline,
} from "react-icons/io5";

import "../StudentDashboard.css";
import "../StaffDashboard.css";
import logo from "../../assets/logo.png";
import specialistAvatar from "../../assets/manger.png"; // You can use a different avatar

const SpecialistSidebar = () => {
  const navigate = useNavigate();
  const location = useLocation();
  const [isSidebarOpen, setIsSidebarOpen] = useState(false);

  // Get user info from localStorage
  const user = JSON.parse(localStorage.getItem("user") || "{}");

  // Simple navigation items for specialists
  const navItems = [
    {
      path: "/specialist/report",
      label: "Submit Report",
      icon: <IoDocumentTextOutline className="nav-icon" />,
    },
    {
      path: "/specialist/profile",
      label: "My Profile",
      icon: <IoPersonOutline className="nav-icon" />,
    },
  ];

  const handleNavigate = (path) => {
    navigate(path);
    setIsSidebarOpen(false);
  };

  const handleLogout = () => {
    localStorage.removeItem("token");
    localStorage.removeItem("userRole");
    localStorage.removeItem("user");
    navigate("/");
  };

  return (
    <>
      <button
        className="mobile-menu-toggle"
        onClick={() => setIsSidebarOpen(true)}
      >
        <IoMenuOutline />
      </button>

      <aside className={`sidebar ${isSidebarOpen ? "open" : ""}`}>
        <div className="logo-container">
          <img src={logo} alt="Logo" className="logo" />
          <IoCloseOutline
            className="sidebar-close-btn"
            onClick={() => setIsSidebarOpen(false)}
          />
        </div>
        <div className="user-profile">
          <img
            src={specialistAvatar}
            alt="Specialist"
            className="profile-pic-small"
          />
          <div>
            <p className="user-name">{user.name || "Specialist"}</p>
            <p className="user-role">Specialist</p>
          </div>
        </div>
        <nav className="nav-menu">
          <ul className="nav-submenu">
            {navItems.map((item) => (
              <li
                key={item.path}
                onClick={() => handleNavigate(item.path)}
                className={location.pathname === item.path ? "active" : ""}
              >
                {item.icon} {item.label}
              </li>
            ))}
            <li
              onClick={handleLogout}
              className="logout-item"
              style={{
                marginTop: "auto",
                borderTop: "1px solid #eee",
                paddingTop: "10px",
                color: "#dc3545",
                cursor: "pointer",
              }}
            >
              <IoLogOutOutline className="nav-icon" /> Logout
            </li>
          </ul>
        </nav>
      </aside>
    </>
  );
};

export default SpecialistSidebar;
