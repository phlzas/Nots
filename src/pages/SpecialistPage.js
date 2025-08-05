import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import api from "../services/api";
import { sendNotification } from "./SendNotificationFunction";

// Import reusable components
import SpecialistSidebar from "./components/SpecialistSidebar";
import AdminHeader from "./components/AdminHeader";

// Import CSS
import "./StudentDashboard.css";
import "./StaffDashboard.css";
import "./SpecialistReportForm.css";

const SpecialistPage = () => {
  const navigate = useNavigate();

  // State for form fields
  const [studentName, setStudentName] = useState("");
  const [description, setDescription] = useState("");
  const [specialistSignature, setSpecialistSignature] = useState("");

  // State for loading and error handling
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState("");

  const handleSubmit = async (e) => {
    e.preventDefault();
    setError(""); // Clear previous errors

    if (!studentName || !description || !specialistSignature) {
      setError(
        "Please fill out Student Name, Description, and Specialist Signature."
      );
      return;
    }

    setIsLoading(true);

    // This is the data structure your .NET API will expect for creating a report
    const reportData = {
      studentName,
      description,
      specialistSignature,
    };

    try {
      // --- STEP 1: Send the report to the database ---
      const reportResponse = await api.post("/api/Reports", reportData);

      if (reportResponse.status === 201) {
        // 201 Created is the success status for POST

        // --- STEP 2: If report is saved, send the notification ---
        const notificationData = {
          title: "New Specialist Report Submitted",
          descreption: `A new report for student ${studentName} is awaiting your review.`,
          role: "Manager", // Target the notification to managers
          date: new Date().toISOString(),
          isRidden: false,
        };

        // This is a "fire and forget" call, we don't strictly need to wait for it
        // unless we want to show a success message for both actions.
        sendNotification(
          notificationData.title,
          notificationData.descreption,
          notificationData.role
        );

        // --- STEP 3: Success! ---
        alert("Report submitted successfully and manager notified!");
        // Clear the form after successful submission
        setStudentName("");
        setDescription("");
        setSpecialistSignature("");
        // Stay on the same page to allow submitting more reports
      }
    } catch (err) {
      console.error("Failed to submit report:", err);
      setError(
        err.response?.data?.message ||
          "An error occurred while submitting the report."
      );
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <div className="dashboard-layout">
      <SpecialistSidebar />
      <main className="main-content">
        <AdminHeader />
        <section className="content-area">
          <div className="form-container card">
            {/* Use the new handleSubmit for the form's onSubmit event */}
            <form onSubmit={handleSubmit}>
              <h2>Submit Specialist Report</h2>

              {error && <p className="form-error-message">{error}</p>}

              <div className="form-group">
                <label htmlFor="studentName">Student Name</label>
                <input
                  type="text"
                  id="studentName"
                  value={studentName}
                  onChange={(e) => setStudentName(e.target.value)}
                  required
                />
              </div>

              <div className="form-group">
                <label htmlFor="description">Report Description</label>
                <textarea
                  id="description"
                  placeholder="Write your observations..."
                  value={description}
                  onChange={(e) => setDescription(e.target.value)}
                  required
                ></textarea>
              </div>

              <div className="form-group">
                <label htmlFor="specialistSig">
                  Specialist Signature (Your Name)
                </label>
                <input
                  type="text"
                  id="specialistSig"
                  value={specialistSignature}
                  onChange={(e) => setSpecialistSignature(e.target.value)}
                  required
                />
              </div>

              {/* The date and manager signature are handled by the backend now */}

              {/* This button now triggers the form's onSubmit */}
              <button type="submit" className="submit-btn" disabled={isLoading}>
                {isLoading ? "Submitting..." : "Send to Manager"}
              </button>
            </form>
          </div>
        </section>
      </main>
    </div>
  );
};

export default SpecialistPage;
