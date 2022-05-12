// File:    AppointmenService.cs
// Author:  Dusko
// Created: Sunday, 10 April 2022 22:42:17
// Purpose: Definition of Class AppointmenService

using Model;
using Repository;
using System;
using System.Collections.Generic;


namespace Service
{
    public class AppointmentSurveyService
    {
        public const int MAX_SUGGESTIONS = 30;
        private static AppointmentSurveyService instance = null;
        List<AppointmentSurvey> appointments = new List<AppointmentSurvey>();
        
        public Boolean CreateAppointmentSurvey(AppointmentSurvey newSurvey)
        {
            return AppointmentSurveyRepository.Instance.CreateAppointmentSurvey(newSurvey);
        }

        public AppointmentSurvey ReadAppointmentSurvey(int id)
        {
            return AppointmentSurveyRepository.Instance.ReadAppointmentSurvey(id);
        }

        public Boolean UpdateAppointmentSurvey(AppointmentSurvey survey)
        {
            return AppointmentSurveyRepository.Instance.UpdateAppointmentSurvey(survey);
        }

        public Boolean DeleteAppointmentSurvey(int id)
        {
            return AppointmentSurveyRepository.Instance.DeleteAppointmentSurvey(id);
        }

        public List<AppointmentSurvey> GetAllAppointmentSurveys()
        {
            return AppointmentSurveyRepository.Instance.GetAllAppointmentSurveys();
        }
        public List<int> getAllAppointmentSurveyIds()
        {
            return AppointmentSurveyRepository.Instance.getAllAppointmentSurveyIds();
        }
        public AppointmentSurveyService()
        {

        }

        public static AppointmentSurveyService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppointmentSurveyService();
                }
                return instance;
            }
        }
        public Boolean DoneSurvey(Appointment appointment)
        {
            Boolean done = false;
            if (GetAllAppointmentsIds().Contains(appointment.Id))
            {
                done = true;
            }
            return done;
        }
        public List<int> GetAllAppointmentsIds()
        {
            List<int> ids = new List<int>();
            foreach(Appointment appointment in AppointmenService.Instance.GetAllAppointments())
            {
                ids.Add(appointment.Id);
            }
            return ids;
        }
    }
}