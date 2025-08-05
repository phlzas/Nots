// Staff API service
const API_BASE_URL = "https://localhost:7131/api/staff";

const getAuthHeaders = () => {
  const token = localStorage.getItem("token");
  return {
    "Content-Type": "application/json",
    Authorization: `Bearer ${token}`,
  };
};

export const staffService = {
  // Get today's staff attendance
  getTodayAttendance: async () => {
    const today = new Date().toISOString().split("T")[0];
    const response = await fetch(`${API_BASE_URL}/attendance/${today}`, {
      method: "GET",
      headers: getAuthHeaders(),
    });

    if (!response.ok) {
      throw new Error("Failed to fetch staff attendance");
    }

    return await response.json();
  },

  // Get daily staff report with stats
  getDailyReport: async (date = new Date()) => {
    const dateStr = date.toISOString().split("T")[0];
    const response = await fetch(
      `${API_BASE_URL}/daily-report?date=${dateStr}`,
      {
        method: "GET",
        headers: getAuthHeaders(),
      }
    );

    if (!response.ok) {
      throw new Error("Failed to fetch daily report");
    }

    return await response.json();
  },

  // Get staff by department
  getStaffByDepartment: async (department, date = null) => {
    let url = `${API_BASE_URL}/department/${department}`;
    if (date) {
      const dateStr = date.toISOString().split("T")[0];
      url += `?date=${dateStr}`;
    }

    const response = await fetch(url, {
      method: "GET",
      headers: getAuthHeaders(),
    });

    if (!response.ok) {
      throw new Error("Failed to fetch department staff");
    }

    return await response.json();
  },

  // Check in staff
  checkInStaff: async (staffData) => {
    const response = await fetch(`${API_BASE_URL}/checkin`, {
      method: "POST",
      headers: getAuthHeaders(),
      body: JSON.stringify(staffData),
    });

    if (!response.ok) {
      throw new Error("Failed to check in staff");
    }

    return await response.json();
  },

  // Update staff attendance
  updateStaffAttendance: async (id, updateData) => {
    const response = await fetch(`${API_BASE_URL}/${id}`, {
      method: "PUT",
      headers: getAuthHeaders(),
      body: JSON.stringify(updateData),
    });

    if (!response.ok) {
      throw new Error("Failed to update staff attendance");
    }

    return await response.json();
  },

  // Get staff attendance history
  getStaffHistory: async (accountId, fromDate = null, toDate = null) => {
    let url = `${API_BASE_URL}/history/${accountId}`;
    const params = new URLSearchParams();

    if (fromDate)
      params.append("fromDate", fromDate.toISOString().split("T")[0]);
    if (toDate) params.append("toDate", toDate.toISOString().split("T")[0]);

    if (params.toString()) {
      url += `?${params.toString()}`;
    }

    const response = await fetch(url, {
      method: "GET",
      headers: getAuthHeaders(),
    });

    if (!response.ok) {
      throw new Error("Failed to fetch staff history");
    }

    return await response.json();
  },
};
