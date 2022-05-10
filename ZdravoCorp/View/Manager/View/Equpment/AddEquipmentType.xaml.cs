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
using ZdravoCorp.View.Core;
using ZdravoCorp.View.Manager.ViewModel.Equipment;

namespace ZdravoCorp.View.Manager.View.Equipment
{
    /// <summary>
    /// Interaction logic for AddEquipmentType.xaml
    /// </summary>
    public partial class AddEquipmentType : UserControl, WindowInterface
    {
        private AddEquipmentTypeViewModel viewModel;
        public AddEquipmentType(AddEquipmentTypeViewModel model)
        {
            InitializeComponent();
            this.viewModel = model;
            this.DataContext = viewModel;
        }

        public string getTitle()
        {
            return "Add Equipment Type";
        }
    }
}
