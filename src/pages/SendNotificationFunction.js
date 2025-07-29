import React from 'react';
import axios from 'axios';
import api from '../services/api';
import { Title } from 'chart.js';


export const sendNotification = async (title, descreption) => {
  try {
    
    await api.post('api/Notification', {
      title,
      descreption,
      role : 'Admin', 
      date: new Date().toISOString(), 
      isRidden: false
    });
  } catch (err) {
    console.error('Notification sending failed:', err);
  }
};
