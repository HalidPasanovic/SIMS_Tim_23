﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ZdravoCorp.View.Core;

namespace ZdravoCorp.View.Manager.ViewModel
{
    public class MainViewModel: ObservableObject, ViewModelInterface
    {
        public RelayCommand RoomsCommand { get; set; }

        public RelayCommand EquipmentsCommand { get; set; }

        public RelayCommand MedicationsCommand { get; set; }

        public RelayCommand SurveyCommand { get; set; }

        public UserControl CurrentView
        {
            get => ContentViewModel.Instance.CurrentView;
            set
            {
                if (value != ContentViewModel.Instance.CurrentView)
                {
                    ContentViewModel.Instance.WindowBrowser.AddWindow(value);
                    ContentViewModel.Instance.CurrentView = value;
                    OnPropertyChanged();
                }
            }
        }
        public MainViewModel()
        {
            RoomsCommand = new RelayCommand(o =>
            {
                CurrentView = new View.Rooms.Rooms(new Rooms.RoomsViewModel());
            });

            EquipmentsCommand = new RelayCommand(o =>
            {
                CurrentView = new View.Equipments.Equipment(new Equipments.EquipmentViewModel());
            });

            MedicationsCommand = new RelayCommand(o =>
            {
                CurrentView = new View.Medications.Medications(new Medications.MedicationsViewModel());
            });

            SurveyCommand = new RelayCommand(o =>
            {
                CurrentView = new View.Surveys.Surveys(new Surveys.SurveysViewModel());
            });
        }

        public string GetTitle()
        {
            return "Home";
        }

        public void Update()
        {
            
        }
    }
}
