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
using System.Windows.Shapes;

namespace ZdravoCorp.View.Patient.View.MedicalHistory
{
    /// <summary>
    /// Interaction logic for MedicalHistory.xaml
    /// </summary>
    public partial class MedicalHistory : Window
    {
        public MedicalHistory()
        {
            InitializeComponent();
            LabAnalysisTable.DataContext = new ViewModel.MedicalHistory.LabAnalysisViewModel();
            OperationsTable.DataContext = new ViewModel.MedicalHistory.OperationViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            View.MedicalHistory.LabResults w = new View.MedicalHistory.LabResults((Modell.MedicalHistory.LabAnalysis)LabAnalysisTable.SelectedItem);
            w.ShowDialog();
        }
    }
}
