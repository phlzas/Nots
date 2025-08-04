// --- File: src/pages/AbsencePage.js (Updated with Context) ---

import React, { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import { useAbsence } from '../contexts/AbsenceContext';
import { FiTrash2 } from 'react-icons/fi';

// Import reusable components and data
import TeacherSidebar from './components/TeacherSidebar';
import AppHeader from './components/AppHeader';
import { gradesData } from '../mock-attendance-page ';
import '../pages/Absence.css';

// --- ADDED: Data for the new Session filter dropdown ---
const sessionsData = [1, 2, 3, 4, 5, 6, 7, 8];

const AbsencePage = () => {
    const navigate = useNavigate();
    const [user, setUser] = useState(null);

    // Get absences from context
    const { getAbsences, removeAbsence } = useAbsence();
    
    // State for filter controls
    const [selectedGrade, setSelectedGrade] = useState('');
    const [selectedClass, setSelectedClass] = useState('');
    const [selectedDate, setSelectedDate] = useState('');
    const [selectedSession, setSelectedSession] = useState('');
    
    // Get filtered absences based on current filters
    const filteredAbsences = getAbsences({
        grade: selectedGrade || undefined,
        class: selectedClass || undefined,
        session: selectedSession || undefined,
        date: selectedDate || undefined
    });

    useEffect(() => {
        const storedUser = localStorage.getItem('user');
        if (storedUser) {
            setUser(JSON.parse(storedUser));
        } else {
            navigate('/');
        }
    }, [navigate]);


    
    // Reset class and session filters when grade changes
    const handleGradeChange = (grade) => {
        setSelectedGrade(grade);
        setSelectedClass('');
        setSelectedSession(''); // Also reset session
    };
    
    // Reset session filter when class changes
    const handleClassChange = (className) => {
        setSelectedClass(className);
        setSelectedSession('');
    };

    return (
        <div className="dashboard-layout">
            <TeacherSidebar user={user} />
            <main className="main-content">
                <AppHeader user={user} />
                <section className="content-area">
                    <div className="content-header">
                        <h2>Absence Page</h2>
                    </div>

                    {/* --- MODIFIED: Filter controls now include Session dropdown --- */}
                    <div className="card absence-log-filters">
                        <div className="filter-group">
                            <label>Filter by Grade</label>
                            <select value={selectedGrade} onChange={(e) => handleGradeChange(e.target.value)}>
                                <option value="">All Grades</option>
                                {Object.keys(gradesData).filter(g => g).map(grade => (<option key={grade} value={grade}>{grade}</option>))}
                            </select>
                        </div>
                        <div className="filter-group">
                            <label>Filter by Class</label>
                            <select value={selectedClass} onChange={(e) => handleClassChange(e.target.value)} disabled={!selectedGrade}>
                                <option value="">All Classes</option>
                                {gradesData[selectedGrade]?.map(c => (<option key={c} value={c}>{c}</option>))}
                            </select>
                        </div>
                        {/* --- ADDED: Session Filter Dropdown --- */}
                        <div className="filter-group">
                            <label>Filter by Session</label>
                            <select value={selectedSession} onChange={(e) => setSelectedSession(e.target.value)} disabled={!selectedClass}>
                                <option value="">All Sessions</option>
                                {sessionsData.map(session => (<option key={session} value={session}>Session {session}</option>))}
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

                    {/* Absence Log Table (unchanged) */}
                    <div className="card absence-log-container">
                        <h3>Absence Records</h3>
                        <hr />
                        <div className="table-container">
                            <table className="absence-table">
                                <thead>
                                    <tr>
                                        <th>Student Name</th>
                                        <th>Grade</th>
                                        <th>Class</th>
                                        <th>Session</th>
                                        <th>Date</th>
                                        <th>Recorded At</th>
                                        <th>Actions</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    {filteredAbsences.length > 0 ? (
                                        filteredAbsences.map((absence) => (
                                            <tr key={absence.id}>
                                                <td>{absence.studentName}</td>
                                                <td>{absence.grade}</td>
                                                <td>{absence.class}</td>
                                                <td>{absence.session}</td>
                                                <td>{absence.date}</td>
                                                <td>{new Date(absence.recordedAt).toLocaleString()}</td>
                                                <td>
                                                    <button 
                                                        className="delete-btn"
                                                        onClick={() => removeAbsence(absence.id)}
                                                        title="Delete record"
                                                    >
                                                        <FiTrash2 />
                                                    </button>
                                                </td>
                                            </tr>
                                        ))
                                    ) : (
                                        <tr>
                                            <td colSpan="6" className="no-records">No absence records found</td>
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