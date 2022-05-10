﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZdravoCorp.View.Core;
using ZdravoCorp.View.Manager.View;
using ZdravoCorp.View.Manager.ViewModel.Equipment;
using ZdravoCorp.View.Manager.ViewModel.Rooms;

namespace ZdravoCorp.View.Manager.ViewModel
{
    public class ContentViewModel : ObservableObject
    {
        private static ContentViewModel instance;
        private static readonly object key = new object();

        private WindowBrowser _windowBrowser;
        private String _title;

        private WindowInterface _currentView;

        public WindowInterface CurrentView
        {
            get => _currentView;
            set
            {
                if (value != _currentView)
                {
                    Title = value.getTitle();
                    _currentView = value;
                    OnPropertyChanged();
                }
            }
        }

        public WindowBrowser WindowBrowser { get => _windowBrowser; set => _windowBrowser = value; }

        public string Title
        {
            get => _title;
            set
            {
                if (value != _title)
                {
                    _title = value;
                    OnPropertyChanged();
                }
            }
        }

        public RelayCommand MainViewCommand { get; set; }

        public RelayCommand RoomViewCommand { get; set; }

        public RelayCommand EquipmentViewCommand { get; set; }

        public RelayCommand BackViewCommand { get; set; }

        public ContentViewModel()
        {
            WindowBrowser = new WindowBrowser();

            CurrentView = new Home(new MainViewModel());
            WindowBrowser.AddWindow(CurrentView);

            MainViewCommand = new RelayCommand(o =>
            {
                CurrentView = new Home(new MainViewModel());
                WindowBrowser.AddWindow(CurrentView);
            });

            RoomViewCommand = new RelayCommand(o =>
            {
                CurrentView = new View.Room.Rooms(new RoomsViewModel());
                WindowBrowser.AddWindow(CurrentView);
            });

            EquipmentViewCommand = new RelayCommand(o =>
            {
                CurrentView = new View.Equipment.Equipment(new EquipmentViewModel());
                WindowBrowser.AddWindow(CurrentView);
            });

            BackViewCommand = new RelayCommand(o =>
            {
                CurrentView = WindowBrowser.BackWindow();
            });
        }

        public static ContentViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        if (instance == null)
                        {
                            instance = new ContentViewModel();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
