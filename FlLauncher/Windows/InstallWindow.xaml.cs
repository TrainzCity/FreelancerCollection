using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FlLauncher.Entity;

namespace FlLauncher.Windows
{
    /// <summary>
    /// Логика взаимодействия для InstallWindow.xaml
    /// </summary>
    public partial class InstallWindow : Window
    {
        private Mod _selectedMod;
        public InstallWindow()
        {
            InitializeComponent();
        }
        public InstallWindow(Mod currentMod)
        {
            InitializeComponent();
            _selectedMod = currentMod;
            Tbl_Description.Text = currentMod.Description;
        }

        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
