import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";

// Import Chart.js components
import { Bar, Line, Doughnut } from "react-chartjs-2";
import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  BarElement,
  PointElement,
  LineElement,
  ArcElement,
  Title,
  Tooltip,
  Legend,
} from "chart.js";

// Import reusable components
import TeacherSidebar from "./components/TeacherSidebar";
import AppHeader from "./components/AppHeader";

import "./StudentDashboard.css"; // For base layout
import "./AttendancePage.css"; // Specific styles for AttendancePage

// Register Chart.js components
ChartJS.register(
  CategoryScale,
  LinearScale,
  BarElement,
  PointElement,
  LineElement,
  ArcElement,
  Title,
  Tooltip,
  Legend
);

const AttendancePage = () => {
  const navigate = useNavigate();
  const [user, setUser] = useState(null);
  const [analyticsData, setAnalyticsData] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const storedUser = localStorage.getItem("user");
    if (storedUser) setUser(JSON.parse(storedUser));
    else navigate("/");
  }, [navigate]);

  useEffect(() => {
    fetchAttendanceAnalytics();
  }, []);

  const fetchAttendanceAnalytics = async () => {
    try {
      setLoading(true);
      const response = await fetch(
        "http://localhost:5050/api/Attendance/analytics",
        {
          method: "GET",
          headers: {
            "Content-Type": "application/json",
          },
        }
      );

      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }

      const data = await response.json();
      setAnalyticsData(data);
      setError(null);
    } catch (err) {
      console.error("Error fetching attendance analytics:", err);
      setError("Failed to load attendance data. Please try again later.");
    } finally {
      setLoading(false);
    }
  };

  // Prepare chart data from backend response
  const getChartData = () => {
    if (!analyticsData) return null;

    const classPerformanceData = {
      labels: analyticsData.classPerformance?.map((c) => c.className) || [],
      datasets: [
        {
          label: "Attendance Rate (%)",
          data:
            analyticsData.classPerformance?.map(
              (c) => Math.round(c.attendanceRate * 10) / 10
            ) || [],
          backgroundColor: "rgba(230, 0, 40, 0.6)",
          borderColor: "rgba(230, 0, 40, 1)",
          borderWidth: 1,
        },
      ],
    };

    const attendanceTrendData = {
      labels:
        analyticsData.attendanceTrend?.map((t) =>
          new Date(t.date).toLocaleDateString("en-US", {
            month: "short",
            day: "numeric",
          })
        ) || [],
      datasets: [
        {
          label: "Daily Attendance %",
          data:
            analyticsData.attendanceTrend?.map(
              (t) => Math.round(t.attendanceRate * 10) / 10
            ) || [],
          fill: false,
          borderColor: "#3E8BFF",
          tension: 0.1,
        },
      ],
    };

    const statusDistributionData = {
      labels: ["Present", "Absent", "Late"],
      datasets: [
        {
          data: [
            analyticsData.statusDistribution?.present || 0,
            analyticsData.statusDistribution?.absent || 0,
            analyticsData.statusDistribution?.late || 0,
          ],
          backgroundColor: ["#28a745", "#dc3545", "#ffc107"],
          hoverOffset: 4,
        },
      ],
    };

    return {
      classPerformanceData,
      attendanceTrendData,
      statusDistributionData,
    };
  };

  const chartData = getChartData();

  if (loading) {
    return (
      <div className="dashboard-layout">
        <TeacherSidebar user={user} />
        <main className="main-content">
          <AppHeader user={user} />
          <section className="content-area">
            <div className="content-header">
              <h2>Attendance Analysis</h2>
            </div>
            <div className="loading-container">
              <p>Loading attendance data...</p>
            </div>
          </section>
        </main>
      </div>
    );
  }

  if (error) {
    return (
      <div className="dashboard-layout">
        <TeacherSidebar user={user} />
        <main className="main-content">
          <AppHeader user={user} />
          <section className="content-area">
            <div className="content-header">
              <h2>Attendance Analysis</h2>
            </div>
            <div className="error-container">
              <p className="error-message">{error}</p>
              <button
                onClick={fetchAttendanceAnalytics}
                className="retry-button"
              >
                Retry
              </button>
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
            <h2>Attendance Analysis</h2>
          </div>

          {/* KPI Cards */}
          <div className="kpi-grid">
            <div className="card kpi-card">
              <p className="kpi-value">
                {analyticsData?.kpiData?.attendanceRate || 0}%
              </p>
              <p className="kpi-label">Overall Attendance</p>
            </div>
            <div className="card kpi-card">
              <p className="kpi-value">
                {analyticsData?.kpiData?.totalAbsences || 0}
              </p>
              <p className="kpi-label">Total Absences</p>
            </div>
            <div className="card kpi-card">
              <p className="kpi-value">
                {analyticsData?.kpiData?.totalLates || 0}
              </p>
              <p className="kpi-label">Total Lates</p>
            </div>
            <div className="card kpi-card">
              <p className="kpi-value">
                {analyticsData?.kpiData?.topClass || "N/A"}
              </p>
              <p className="kpi-label">Top Performing Class</p>
            </div>
          </div>

          {/* Charts Grid */}
          {chartData && (
            <>
              <div className="charts-grid">
                <div className="card chart-card">
                  <h3>Class Performance</h3>
                  <Bar
                    data={chartData.classPerformanceData}
                    options={{ responsive: true, maintainAspectRatio: false }}
                  />
                </div>
                <div className="card chart-card">
                  <h3>Attendance Trend (Last 30 Days)</h3>
                  <Line
                    data={chartData.attendanceTrendData}
                    options={{ responsive: true, maintainAspectRatio: false }}
                  />
                </div>
              </div>

              <div className="charts-grid-secondary">
                <div className="card chart-card">
                  <h3>Status Distribution</h3>
                  <Doughnut
                    data={chartData.statusDistributionData}
                    options={{ responsive: true, maintainAspectRatio: false }}
                  />
                </div>
                <div className="card at-risk-card">
                  <h3>Students with Low Attendance</h3>
                  <table className="attendance-table">
                    <thead>
                      <tr>
                        <th>Student</th>
                        <th>Class</th>
                        <th>Absences</th>
                        <th>Lates</th>
                        <th>Rate</th>
                      </tr>
                    </thead>
                    <tbody>
                      {analyticsData?.atRiskStudents?.length > 0 ? (
                        analyticsData.atRiskStudents.map((student) => (
                          <tr key={student.id}>
                            <td>{student.name}</td>
                            <td>{student.className}</td>
                            <td>{student.absences}</td>
                            <td>{student.lates}</td>
                            <td>{Math.round(student.attendanceRate)}%</td>
                          </tr>
                        ))
                      ) : (
                        <tr>
                          <td colSpan="5">No at-risk students found</td>
                        </tr>
                      )}
                    </tbody>
                  </table>
                </div>
              </div>
            </>
          )}
        </section>
      </main>
    </div>
  );
};

export default AttendancePage;
