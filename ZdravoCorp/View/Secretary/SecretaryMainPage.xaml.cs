﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZdravoCorp.View.Secretary
{
    /// <summary>
    /// Interaction logic for SecretaryMainPage.xaml
    /// </summary>
    public partial class SecretaryMainPage : Page
    {
        private SecretaryMainWindow secretaryMainWindow;
        public SecretaryMainPage(SecretaryMainWindow smw)
        {
            InitializeComponent();
            this.secretaryMainWindow = smw;
        }

        private void Appointments_Click(object sender, RoutedEventArgs e)
        {
            
            SecretaryAppointments secretaryAppointments = new SecretaryAppointments(this, secretaryMainWindow);
            
            secretaryMainWindow.Content = secretaryAppointments;

              
        }

        private void Holidays_Click(object sender, RoutedEventArgs e)
        {
            View.HolidayRequestsView holidayRequestsView = new View.HolidayRequestsView(this, secretaryMainWindow);
            secretaryMainWindow.Content = holidayRequestsView;
        }

        private void EquipmentOrder_Click(object sender, RoutedEventArgs e)
        {
            View.EquipmentOrderView equipmentOrderView = new View.EquipmentOrderView(this, secretaryMainWindow);
            secretaryMainWindow.Content = equipmentOrderView;
        }

        private void MyAccount_Click(object sender, RoutedEventArgs e)
        {
            MyAccount myAccount = new MyAccount(this, secretaryMainWindow);
            secretaryMainWindow.Content = myAccount;
        }

        private void Accounts_Click(object sender, RoutedEventArgs e)
        {
            SecretaryPatients secretaryPatients = new SecretaryPatients(this, secretaryMainWindow);
            secretaryMainWindow.Content = secretaryPatients;
        }

        private void Emergency_Click(object sender, RoutedEventArgs e)
        {
            View.EmergencyAppointmentView emergencyAppointment = new View.EmergencyAppointmentView(this, secretaryMainWindow);
            secretaryMainWindow.Content = emergencyAppointment;
        }

        private void Meetings_Click(object sender, RoutedEventArgs e)
        {
            Meetings meetings = new Meetings(this, secretaryMainWindow);
            secretaryMainWindow.Content = meetings;
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow mw = new MainWindow();
            mw.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            
            secretaryMainWindow.Close();
            mw.ShowDialog();
        }
    }
}
