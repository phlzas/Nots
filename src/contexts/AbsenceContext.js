import React, { createContext, useState, useContext, useEffect } from 'react';

const AbsenceContext = createContext();

export const AbsenceProvider = ({ children }) => {
    const [absences, setAbsences] = useState(() => {
        // Load absences from localStorage if they exist
        const saved = localStorage.getItem('absenceRecords');
        return saved ? JSON.parse(saved) : [];
    });

    // Save absences to localStorage whenever they change
    useEffect(() => {
        localStorage.setItem('absenceRecords', JSON.stringify(absences));
    }, [absences]);

    const addAbsence = (student, className, session, date) => {
        const newAbsence = {
            id: Date.now(),
            studentId: student.id,
            studentName: student.name,
            grade: className.split(' ')[0],
            class: className,
            session: parseInt(session, 10),
            date: date || new Date().toISOString().split('T')[0], // YYYY-MM-DD format
            status: 'Absent',
            recordedAt: new Date().toISOString()
        };
        
        setAbsences(prev => [...prev, newAbsence]);
    };

    const getAbsences = (filters = {}) => {
        return absences.filter(absence => {
            return Object.entries(filters).every(([key, value]) => {
                if (!value) return true;
                return absence[key] === value;
            });
        });
    };

    const removeAbsence = (id) => {
        setAbsences(prev => prev.filter(absence => absence.id !== id));
    };

    return (
        <AbsenceContext.Provider value={{ absences, addAbsence, getAbsences, removeAbsence }}>
            {children}
        </AbsenceContext.Provider>
    );
};

export const useAbsence = () => {
    const context = useContext(AbsenceContext);
    if (!context) {
        throw new Error('useAbsence must be used within an AbsenceProvider');
    }
    return context;
};
