import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { FiTrash2 } from "react-icons/fi";

// Import reusable components
import TeacherSidebar from "./components/TeacherSidebar";
import AppHeader from "./components/AppHeader";
import "../pages/Absence.css";

// Sessions data
const sessionsData = [1, 2, 3, 4, 5, 6, 7, 8];

const AbsencePage = () => {
  const navigate = useNavigate();
  const [user, setUser] = useState(null);

  // State for data
  const [absences, setAbsences] = useState([]);
  const [gradesData, setGradesData] = useState({});
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  // State for filter controls
  const [selectedGrade, setSelectedGrade] = useState("");
  const [selectedClass, setSelectedClass] = useState("");
  const [selectedDate, setSelectedDate] = useState("");
  const [selectedSession, setSelectedSession] = useState("");

  useEffect(() => {
    const storedUser = localStorage.getItem("user");
    if (storedUser) {
      setUser(JSON.parse(storedUser));
    } else {
      navigate("/");
    }
  }, [navigate]);

  useEffect(() => {
    fetchGradesAndClasses();
    fetchAbsences();
  }, []);

  useEffect(() => {
    fetchAbsences();
  }, [selectedGrade, selectedClass, selectedDate, selectedSession]);

  const fetchGradesAndClasses = async () => {
    try {
      const response = await fetch(
        "http://localhost:5050/api/Absence/grades-classes"
      );
      if (!response.ok) throw new Error("Failed to fetch grades and classes");

      const data = await response.json();
      const formattedData = {};
      data.forEach((grade) => {
        formattedData[grade.gradeName] = grade.classes;
      });
      setGradesData(formattedData);
    } catch (err) {
      console.error("Error fetching grades and classes:", err);
      setError("Failed to load grades and classes");
    }
  };

  const fetchAbsences = async () => {
    try {
      setLoading(true);
      const params = new URLSearchParams();
      if (selectedGrade) params.append("grade", selectedGrade);
      if (selectedClass) params.append("className", selectedClass);
      if (selectedSession) params.append("session", selectedSession);
      if (selectedDate) params.append("date", selectedDate);

      const response = await fetch(
        `http://localhost:5050/api/Absence/filtered?${params}`
      );
      if (!response.ok) throw new Error("Failed to fetch absences");

      const data = await response.json();
      setAbsences(data);
      setError(null);
    } catch (err) {
      console.error("Error fetching absences:", err);
      setError("Failed to load absence data");
    } finally {
      setLoading(false);
    }
  };

  const handleDeleteAbsence = async (id) => {
    if (
      !window.confirm("Are you sure you want to delete this absence record?")
    ) {
      return;
    }

    try {
      const response = await fetch(`http://localhost:5050/api/Absence/${id}`, {
        method: "DELETE",
      });

      if (!response.ok) throw new Error("Failed to delete absence record");

      // Refresh the data
      fetchAbsences();
    } catch (err) {
      console.error("Error deleting absence:", err);
      alert("Failed to delete absence record");
    }
  };

  // Reset class and session filters when grade changes
  const handleGradeChange = (grade) => {
    setSelectedGrade(grade);
    setSelectedClass("");
    setSelectedSession("");
  };

  // Reset session filter when class changes
  const handleClassChange = (className) => {
    setSelectedClass(className);
    setSelectedSession("");
  };

  if (loading && absences.length === 0) {
    return (
      <div className="dashboard-layout">
        <TeacherSidebar user={user} />
        <main className="main-content">
          <AppHeader user={user} />
          <section className="content-area">
            <div className="content-header">
              <h2>Absence Page</h2>
            </div>
            <div className="loading-container">
              <p>Loading absence data...</p>
            </div>
          </section>
        </main>
      </div>
    );
  }

  return (
    <div className="dashboard-layout">
      <TeacherSidebar user={user} />
      <main className="main-content">
        <AppHeader user={user} />
        <section className="content-area">
          <div className="content-header">
            <h2>Absence Page</h2>
          </div>

          {error && (
            <div className="error-container">
              <p className="error-message">{error}</p>
              <button
                onClick={() => {
                  fetchGradesAndClasses();
                  fetchAbsences();
                }}
                className="retry-button"
              >
                Retry
              </button>
            </div>
          )}

          {/* Filter controls */}
          <div className="card absence-log-filters">
            <div className="filter-group">
              <label>Filter by Grade</label>
              <select
                value={selectedGrade}
                onChange={(e) => handleGradeChange(e.target.value)}
              >
                <option value="">All Grades</option>
                {Object.keys(gradesData).map((grade) => (
                  <option key={grade} value={grade}>
                    {grade}
                  </option>
                ))}
              </select>
            </div>
            <div className="filter-group">
              <label>Filter by Class</label>
              <select
                value={selectedClass}
                onChange={(e) => handleClassChange(e.target.value)}
                disabled={!selectedGrade}
              >
                <option value="">All Classes</option>
                {gradesData[selectedGrade]?.map((c) => (
                  <option key={c} value={c}>
                    {c}
                  </option>
                ))}
              </select>
            </div>
            <div className="filter-group">
              <label>Filter by Session</label>
              <select
                value={selectedSession}
                onChange={(e) => setSelectedSession(e.target.value)}
                disabled={!selectedClass}
              >
                <option value="">All Sessions</option>
                {sessionsData.map((session) => (
                  <option key={session} value={session}>
                    Session {session}
                  </option>
                ))}
              </select>
            </div>
            <div className="filter-group">
              <label>Filter by Date</label>
              <input
                type="date"
                value={selectedDate}
                onChange={(e) => setSelectedDate(e.target.value)}
              />
            </div>
          </div>

          {/* Absence Log Table */}
          <div className="card absence-log-container">
            <h3>Absence Records</h3>
            <hr />
            {loading && <p>Loading...</p>}
            <div className="table-container">
              <table className="absence-table">
                <thead>
                  <tr>
                    <th>Student Name</th>
                    <th>Grade</th>
                    <th>Class</th>
                    <th>Session</th>
                    <th>Date</th>
                    <th>Actions</th>
                  </tr>
                </thead>
                <tbody>
                  {absences.length > 0 ? (
                    absences.map((absence) => (
                      <tr key={absence.id}>
                        <td>{absence.studentName}</td>
                        <td>{absence.gradeName}</td>
                        <td>{absence.className}</td>
                        <td>Session {absence.session}</td>
                        <td>{new Date(absence.date).toLocaleDateString()}</td>
                        <td>
                          <button
                            className="delete-btn"
                            onClick={() => handleDeleteAbsence(absence.id)}
                            title="Delete record"
                          >
                            <FiTrash2 />
                          </button>
                        </td>
                      </tr>
                    ))
                  ) : (
                    <tr>
                      <td colSpan="6" className="no-records">
                        No absence records found
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

export default AbsencePage;
