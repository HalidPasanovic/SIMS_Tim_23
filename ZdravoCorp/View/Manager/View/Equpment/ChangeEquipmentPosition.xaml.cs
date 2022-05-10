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

namespace ZdravoCorp.View.Manager.View.Equipment
{
    /// <summary>
    /// Interaction logic for ChangeEquipmentPosition.xaml
    /// </summary>
    public partial class ChangeEquipmentPosition : UserControl, WindowInterface
    {
        public ChangeEquipmentPosition()
        {
            InitializeComponent();
        }

        public string getTitle()
        {
            return "Change Equipment Position";
        }
    }
}
