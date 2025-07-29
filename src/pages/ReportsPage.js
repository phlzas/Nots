// --- File: src/pages/ReportsPage.js (FINAL AND CORRECTED) ---

import React, { useState, useEffect, useMemo } from "react";
import axios from "axios";
import { FaSort, FaSortUp, FaSortDown, FaCheckCircle, FaTimesCircle, FaHourglassHalf } from 'react-icons/fa';


// Import reusable components
import AdminSidebar from "./components/AdminSidebar";
import AdminHeader from "./components/AdminHeader";

// Import CSS
import "./StudentDashboard.css";
import "./StaffDashboard.css";
import './AdvancedTable.css'; // New CSS file for advanced table styles
import api from '../services/api';




// advanced table
const useTable = (data, page = 1, rowsPerPage = 10) => {
  const [tablePage, setTablePage] = useState(page);
  const [sortConfig, setSortConfig] = useState(null);

  const sortedData = useMemo(() => {
    let sortableData = [...data];
    if (sortConfig !== null) {
      sortableData.sort((a, b) => {
        if (a[sortConfig.key] < b[sortConfig.key]) {
          return sortConfig.direction === 'ascending' ? -1 : 1;
        }
        if (a[sortConfig.key] > b[sortConfig.key]) {
          return sortConfig.direction === 'ascending' ? 1 : -1;
        }
        return 0;
      });
    }
    return sortableData;
  }, [data, sortConfig]);

  const paginatedData = useMemo(() => {
    const startIndex = (tablePage - 1) * rowsPerPage;
    return sortedData.slice(startIndex, startIndex + rowsPerPage);
  }, [sortedData, tablePage, rowsPerPage]);

  const requestSort = (key) => {
    let direction = 'ascending';
    if (sortConfig && sortConfig.key === key && sortConfig.direction === 'ascending') {
      direction = 'descending';
    }
    setSortConfig({ key, direction });
  };

  return { paginatedData, requestSort, sortConfig, tablePage, setTablePage };
};


// --- NEW MOCK DATA ---
const mockReports = [
  {
    id: 1678886400000, // A unique ID based on a timestamp
    date: "2024-03-15",
    studentName: "Ali Hassan",
    description:
      "Student showed excellent participation in the group project but needs to focus more on individual assignments.",
    specialistSignature: "Dr. Mona Fikry",
    status: "Accepted",
  },
  {
    id: 1678972800000,
    date: "2024-03-16",
    studentName: "Nour Tarek",
    description:
      "Nour has shown significant improvement in her problem-solving skills this week.",
    specialistSignature: "Eng. Sherif Hamdy",
    status: "Pending",
  },
  {
    id: 1679059200000,
    date: "2024-03-17",
    studentName: "Laila Mostafa",
    description:
      "Laila was disruptive during the session and did not complete the assigned task. Recommend a follow-up.",
    specialistSignature: "Mr. Mohamed Abdelmged", // As requested
    status: "Declined",
  },
];

// --- NEW Confirmation Modal Component ---
const ConfirmationModal = ({
  show,
  onClose,
  onConfirm,
  title,
  actionType,
  children,
}) => {
  if (!show) {
    return null;
  }

  // Determine button class based on action
  const confirmButtonClass =
    actionType === "Accept" ? "btn-confirm-accept" : "btn-confirm-decline";

  return (
    <div className="modal-overlay visible">
      <div className="modal-content confirmation-modal-content">
        <div className="modal-header">
          <h2>{title}</h2>
        </div>
        <div className="confirmation-modal-body">{children}</div>
        <div className="confirmation-modal-actions">
          <button className="btn-cancel" onClick={onClose} style={{ backgroundColor: '#6c757d' }}>
            Cancel
          </button>
          <button className={confirmButtonClass} onClick={onConfirm} style={
            actionType === "Accept"
              ? { backgroundColor: '#27b448ff' } // Style if TRUE
              : { backgroundColor: '#d61125ff' }  // Style if FALSE
          }>
            Confirm
          </button>
        </div>
      </div>
    </div>
  );
};

const ReportsPage = () => {
  const [reports, setReports] = useState([]);
  // State for the confirmation modal
  const [isModalOpen, setIsModalOpen] = useState(false);
  const [selectedReport, setSelectedReport] = useState(null);
  const [actionType, setActionType] = useState(""); // 'Accept' or 'Decline'
  const [expandedReportId, setExpandedReportId] = useState(null);
  const [searchTerm, setSearchTerm] = useState('');


  // // Load reports from mock data on initial render
  // useEffect(() => {
  //   // In a real app, this would be an API call. Here, we use mock data.
  //   setReports(mockReports);
  // }, []);

  // this is use to get the data from the api
  useEffect(() => {
    const fetchReports = async () => {
      try {
        const response = await api.get('api/Reports'); // Replace with your actual API
        setReports(response.data); // Adjust based on your API response structure
      } catch (error) {
        console.error("Error fetching reports:", error);
      }
    };

    fetchReports();
  }, []);

  const handleOpenConfirmation = (report, action) => {
    setSelectedReport(report);
    setActionType(action);
    setIsModalOpen(true);
  };

  // to send report to whatsapp
  const sendReportViaWhatsApp = (report, managerSignature) => {
    // --- IMPORTANT: Replace with the parent's actual phone number ---
    // The number MUST include the country code without '+' or '00'.
    const parentPhoneNumber = "201234567890"; // Example for an Egyptian number

    // Construct the message
    const message = `
*Specialist Report for ${report.studentName}*

*Date:* ${report.date}
*Description:* ${report.description}
*Submitted By:* ${report.specialistSignature}

*Status: Accepted*
*Manager's Signature:* ${managerSignature}

This report has been reviewed and approved by the school management.
`;

    // Encode the message for a URL
    const encodedMessage = encodeURIComponent(message);

    // Create the WhatsApp URL
    const whatsappUrl = `https://wa.me/${parentPhoneNumber}?text=${encodedMessage}`;

    // Open the URL in a new browser tab
    window.open(whatsappUrl, '_blank');
  };




  // const handleConfirmAction = () => {
  //   if (!selectedReport || !actionType) return;

  //   const updatedReports = reports.map((report) =>
  //     report.id === selectedReport.id
  //       ? {
  //           ...report,
  //           status: actionType === "Accept" ? "Accepted" : "Declined",
  //         }
  //       : report
  //   );
  //   setReports(updatedReports);
  //   // Here you would also make an API call to save the change

  //   // Close the modal
  //   setIsModalOpen(false);
  //   setSelectedReport(null);
  //   setActionType("");
  // };

  // this hanlde confirm action by API
  const handleConfirmAction = async () => {
    if (!selectedReport || !actionType) return;

    if (actionType === "Accept") {
      // Here, we assume the manager's name is available.
      // In a real app, you would get this from the logged-in user's data.
      const managerSignature = "Mr. Ahmed Khaled"; // Example manager name

      // Call the WhatsApp function
      sendReportViaWhatsApp(selectedReport, managerSignature);
    }

    const updatedStatus = actionType === "Accept" ? "Accepted" : "Declined";

    try {
      // This part remains the same: update the status in your database
      await api.put(`/api/reports/${selectedReport.id}/status`, {
        status: updatedStatus,
      });

      const updatedReports = reports.map((report) =>
        report.id === selectedReport.id
          ? { ...report, status: updatedStatus }
          : report
      );
      setReports(updatedReports);

    } catch (error) {
      console.error("Failed to update report status:", error);
      alert("Something went wrong while updating the report.");
    }

    // This part also remains the same: close the modal
    setIsModalOpen(false);
    setSelectedReport(null);
    setActionType("");
  };

  // Filter reports based on search term
  const filteredReports = useMemo(() => {
    return reports.filter(report =>
      report.studentName && report.studentName.toLowerCase().includes(searchTerm.toLowerCase())
    );
  }, [reports, searchTerm]);

  const { paginatedData, requestSort, sortConfig, tablePage, setTablePage } = useTable(filteredReports, 1, 10);

  const getSortIcon = (key) => {
    if (!sortConfig || sortConfig.key !== key) {
      return <FaSort />;
    }
    if (sortConfig.direction === 'ascending') {
      return <FaSortUp />;
    }
    return <FaSortDown />;
  };


  return (
    <>
      <div className="dashboard-layout">
        <AdminSidebar />
        <main className="main-content">
          <AdminHeader searchTerm={searchTerm} setSearchTerm={setSearchTerm} />
          <section className="content-area">
            <div className="card">
              <div className="content-header">
                <h2>All Specialist Reports</h2>
              </div>
              <div className="table-responsive">
                <table className="advanced-table">
                  <thead>
                    <tr>
                      <th onClick={() => requestSort('date')}>Date {getSortIcon('date')}</th>
                      <th onClick={() => requestSort('studentName')}>Student Name {getSortIcon('studentName')}</th>
                      <th onClick={() => requestSort('specialistSignature')}>Submitted By {getSortIcon('specialistSignature')}</th>
                      <th>Description</th>
                      <th onClick={() => requestSort('status')}>Status {getSortIcon('status')}</th>
                      <th>Actions</th>
                    </tr>
                  </thead>
                  <tbody>
                    {paginatedData.length > 0 ? (
                      paginatedData.map((report) => (
                        <tr key={report.id}>
                          <td data-label="Date">{new Date(report.date).toLocaleDateString()}</td>
                          <td data-label="Student Name">
                            {report.studentName}
                          </td>
                          <td data-label="Submitted By">
                            {report.specialistSignature}
                          </td>
                          <td data-label="description">
                            {/* This is to handle text show more and less */}
                            {expandedReportId === report.id ? (
                              report.description
                            ) : (
                              <>
                                {report.description.length > 40
                                  ? report.description.slice(0, 40) + "..."
                                  : report.description}
                                {report.description.length > 40 && (
                                  <span
                                    style={{
                                      cursor: "pointer",
                                      marginLeft: 5,
                                      fontSize: "0.8em",
                                      color: "#007bff",
                                    }}
                                    onClick={() =>
                                      setExpandedReportId(report.id)
                                    }
                                    title="Show more"
                                  >
                                    Show more
                                  </span>
                                )}
                              </>
                            )}
                            {expandedReportId === report.id && (
                              <span
                                style={{
                                  cursor: "pointer",
                                  marginLeft: 5,
                                  fontSize: "0.8em",
                                  color: "#007bff",
                                }}
                                onClick={() => setExpandedReportId(null)}
                                title="Show less"
                              >
                                Show less
                              </span>
                            )}
                          </td>
                          <td data-label="Status">
                            <span
                              className={`status-tag status-${report.status.toLowerCase()}`}
                            >
                              {report.status}
                            </span>
                          </td>
                          <td data-label="Actions" className="actions-cell">
                            {report.status === "Pending" ? (
                              <>
                                <button
                                  className="btn-action accept"
                                  onClick={() =>
                                    handleOpenConfirmation(report, "Accept")
                                  }
                                >
                                  Accept
                                </button>
                                <button
                                  className="btn-action decline"
                                  onClick={() =>
                                    handleOpenConfirmation(report, "Decline")
                                  }
                                >
                                  Decline
                                </button>
                              </>
                            ) : (
                              <span>Action Taken</span>
                            )}
                          </td>
                        </tr>
                      ))
                    ) : (
                      <tr>
                        <td colSpan="5" style={{ textAlign: "center" }}>
                          No reports submitted yet.
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

      <ConfirmationModal
        show={isModalOpen}
        onClose={() => setIsModalOpen(false)}
        onConfirm={handleConfirmAction}
        title={`Confirm ${actionType}`}
        actionType={actionType}
      >
        <p>
          Are you sure you want to <strong style={
            actionType === "Accept"
              ? { color: '#28a745' } // Style if TRUE
              : { color: '#dc3545' }  // Style if FALSE
          } >{actionType?.toLowerCase()}</strong>{" "}
          the report for <strong style={{color: 'dc3545' }}>{selectedReport?.studentName}</strong>?
        </p>
      </ConfirmationModal>
    </>
  );
};

export default ReportsPage;
