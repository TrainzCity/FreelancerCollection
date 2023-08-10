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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlLauncher.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Entity.ModPack> _modList;
        public MainWindow()
        {
            InitializeComponent();
            _modList = new List<Entity.ModPack>()
            {
                new Entity.ModPack()
                {
                    Id = 0,
                    Name = "Freelancer Crossfire 2.0 RUS",
                    Description = "hihaha",
                    Mod = new List<Entity.Mod>() {
                        new Entity.Mod()
                        {
                            Id = 0,
                            Name = "Руссификатор Дмитрия Царёва 1.9",
                            Description = "Подходит для версии 1.9",
                            Comment = "",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 1,
                            Name = "Руссификатор Сергея Дмитриева 2.0",
                            Description = "Подходит для версии 2.0",
                            Comment = "Только миссии 14-43",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 2,
                            Name = "Руссификатор Сергея Царёва 2.0",
                            Description = "Подходит для версии 2.0",
                            Comment = "Создан на базе руссификатора 1.9, непереведённый контент не отображается вовсе",
                            InstallUri = "None"
                        }
                    }
                },
                new Entity.ModPack()
                {
                    Id = 1,
                    Name = "Discovery Freelancer",
                    Description = "hihaha",
                    Mod = new List<Entity.Mod>() {
                        new Entity.Mod()
                        {
                            Id = 0,
                            Name = "Discovery Freelancer",
                            Description = "Official Installer",
                            Comment = "Manual Install",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 1,
                            Name = "Discovery Freelancer RUS",
                            Description = "Русскоязычный сервер, клиент на русском языке",
                            Comment = "",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 2,
                            Name = "Discovery Freelancer UKR",
                            Description = "Украиноязычный сервер, клиент на руссом языке",
                            Comment = "",
                            InstallUri = "None"
                        }
                    }
                }
            };
            Dg_Mods.ItemsSource = _modList;

        }

        private void GetMods_Click(object sender, RoutedEventArgs e)
        {
            Entity.Mod mod1 = _modList.FirstOrDefault(p => p.Name == "Freelancer Crossfire 2.0 RUS").Mod.FirstOrDefault(p => p.Name == "Руссификатор Сергея Дмитриева 2.0");
            Entity.Mod mod2 = _modList.FirstOrDefault(p => p.Name == "Discovery Freelancer").Mod.FirstOrDefault(p => p.Name == "Discovery Freelancer");
            MessageBox.Show(mod1.Name + "\n" + mod2.Name);
        }

        private void Dg_Mods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Dg_Mods.SelectedItem is Entity.ModPack)
            {
                Tbl_Mod.Text = (Dg_Mods.SelectedItem as Entity.ModPack).Name;
                Dg_Mods.ItemsSource = (Dg_Mods.SelectedItem as Entity.ModPack).Mod;
            }
            Dg_Mods.UnselectAll();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Tbl_Mod.Text = "Доступные моды";
            Dg_Mods.ItemsSource = _modList;
        }

        private void Dg_Mods_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && Dg_Mods.CurrentCell.Item is Entity.Mod)
            {
                InstallWindow installWindow = new InstallWindow((Dg_Mods.CurrentCell.Item as Entity.Mod));
                installWindow.Show();

            }
        }
    }
}
