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
using System.ComponentModel;

namespace ZdravoCorp.View.Secretary
{
    /// <summary>
    /// Interaction logic for MyAccount.xaml
    /// </summary>
    public partial class MyAccount : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;
        private string surname;
        private string email;
        private string id;
        private string phoneNumber;
        private string address;

        private SecretaryMainWindow secretaryMainWindow;
        private SecretaryMainPage secretaryMainPage;
        

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public MyAccount(SecretaryMainPage smp, SecretaryMainWindow smw)
        {
            this.secretaryMainPage = smp;
            this.secretaryMainWindow = smw;
            InitializeComponent();
            this.DataContext = this;
            loadData();
        }

        public void loadData()
        {
            Namee = "Duško";
            Surname = "Radičić";
            Email = "dusko.rad@gmail.com";
            Id = "1234567890";
            PhoneNumber = "065555333";
            Address = "Kosovska, 80, Novi Sad, Srbija";
        }

        public String Namee
        {
            get => name;
            set
            {
                if (value != name)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public String Surname
        {
            get => surname;
            set
            {
                if (value != surname)
                {
                    surname = value;
                    OnPropertyChanged("Surname");
                }
            }
        }
        public String Email
        {
            get => email;
            set
            {
                if (value != email)
                {
                    email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        public String Id
        {
            get => id;
            set
            {
                if (value != id)
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public String PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (value != phoneNumber)
                {
                    phoneNumber = value;
                    OnPropertyChanged("PhoneNumber");
                }
            }
        }
        public String Address
        {
            get => address;
            set
            {
                if (value != address)
                {
                    address = value;
                    OnPropertyChanged("Address");
                }
            }
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            secretaryMainWindow.Content = secretaryMainPage;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            EditMyAccount editMyAccount = new EditMyAccount(this, secretaryMainWindow);
            editMyAccount.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            editMyAccount.Namee = Namee;
            editMyAccount.Surname = Surname;
            editMyAccount.Email = Email;
            editMyAccount.Id = Id;
            editMyAccount.PhoneNumber = PhoneNumber;
            editMyAccount.Address = Address;
            editMyAccount.ShowDialog();

        }
        //public String Gender
        //{
        //    get => gender;
        //    set
        //    {
        //        if (value != gender)
        //        {
        //            gender = value;
        //            OnPropertyChanged("Gender");
        //        }
        //    }
        //}
    }
}
