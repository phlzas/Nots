// --- File: src/pages/StudentListPage.js (UPDATED with Grade Calculation) ---

import React, { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import { IoAddCircleOutline } from 'react-icons/io5';

// Import reusable components & services
import AdminSidebar from './components/AdminSidebar';
import AdminHeader from './components/AdminHeader';
import api from '../services/api';

// Import CSS
import './StudentDashboard.css';
import './StaffDashboard.css';

// *** 1. ADD THE HELPER FUNCTION HERE ***
const getGradeFromClassId = (classId) => {
  if (classId >= 1 && classId <= 4) return 'Junior';
  if (classId >= 5 && classId <= 8) return 'Wheeler';
  if (classId >= 9 && classId <= 12) return 'Senior';
  return 'Unknown';
};


const StudentListPage = () => {
    const navigate = useNavigate();

    // State management remains the same
    const [allStudents, setAllStudents] = useState([]);
    const [filteredStudents, setFilteredStudents] = useState([]);
    const [selectedGrade, setSelectedGrade] = useState('Junior');
    const [isLoading, setIsLoading] = useState(false);
    const [error, setError] = useState('');

    // This effect fetches all students and processes them
    useEffect(() => {
        const fetchAllStudents = async () => {
            setIsLoading(true);
            setError('');
            try {
                const response = await api.get('/api/StudentProfile');
                
                // *** 2. PROCESS THE DATA AFTER FETCHING ***
                // Use .map() to create a new array where each student
                // object has the new 'grade' property.
                const studentsWithGrade = response.data.map(student => ({
                    ...student, // Copy all original student properties
                    grade: getGradeFromClassId(student.classId) // Add the new grade
                }));

                // *** 3. SET STATE WITH THE PROCESSED DATA ***
                setAllStudents(studentsWithGrade);

            } catch (err) {
                console.error('Failed to fetch students:', err);
                setError('Failed to load student data. Please try again.');
            } finally {
                setIsLoading(false);
            }
        };

        fetchAllStudents();
    }, []); // Runs only once

    // This filtering effect requires NO CHANGES. It will now work
    // correctly because 'allStudents' contains the 'grade' property.
    useEffect(() => {
        if (!allStudents) return;
        const results = allStudents.filter(student => student.grade === selectedGrade);
        setFilteredStudents(results);
    }, [selectedGrade, allStudents]);

    // The entire JSX render block requires NO CHANGES.
    return (
        <div className="dashboard-layout">
            <AdminSidebar />
            <main className="main-content">
                <AdminHeader />
                <section className="content-area">
                    <div className="attendance-table-container card">
                        <div className="content-header student-list-filter">
                            <div className="header-left-side">
                                <h2>Student List</h2>
                                <button
                                    className="btn-add-staff"
                                    onClick={() => navigate('/register')}
                                >
                                    <IoAddCircleOutline />
                                    Add New Student
                                </button>
                            </div>
                            <div className="filter-group">
                                <label htmlFor="grade-select">Select Grade:</label>
                                <select
                                    id="grade-select"
                                    value={selectedGrade}
                                    onChange={(e) => setSelectedGrade(e.target.value)}
                                    disabled={isLoading}
                                >
                                    <option value="Junior">Junior</option>
                                    <option value="Wheeler">Wheeler</option>
                                    <option value="Senior">Senior</option>
                                </select>
                            </div>
                        </div>

                        <div className="table-responsive">
                            {isLoading ? (
                                <p className="loading-text">Loading students...</p>
                            ) : error ? (
                                <p className="error-text">{error}</p>
                            ) : filteredStudents.length === 0 ? (
                                <p className="empty-text">No students found for this grade.</p>
                            ) : (
                                <table className="attendance-table">
                                    <thead>
                                        <tr>
                                            <th>Student Name</th>
                                            <th>ID</th>
                                            <th>Grade</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        {filteredStudents.map((student) => (
                                            <tr key={student.id}>
                                                <td data-label="Student Name">{student.name}</td>
                                                <td data-label="ID">{student.id}</td>
                                                <td data-label="Grade">{student.grade}</td>
                                            </tr>
                                        ))}
                                    </tbody>
                                </table>
                            )}
                        </div>
                    </div>
                </section>
            </main>
        </div>
    );
};

export default StudentListPage;