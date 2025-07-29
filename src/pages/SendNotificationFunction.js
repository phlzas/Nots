import React from 'react';
import axios from 'axios';
import api from '../services/api';
import { Title } from 'chart.js';


export const sendNotification = async (title, descreption , role) => {
  try {
    
    await api.post('api/Notification', {
      title,
      descreption,
      role, 
      date: new Date().toISOString(), 
      isRidden: false
    });
  } catch (err) {
    console.error('Notification sending failed:', err);
  }
};
