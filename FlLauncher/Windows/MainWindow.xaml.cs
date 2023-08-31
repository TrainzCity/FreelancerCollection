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
                    Name = "Freelancer",
                    Description = "hihaha",
                    Mod = new List<Entity.Mod>() {
                        new Entity.Mod()
                        {
                            Id = 0,
                            Name = "Freelancer Original ISO",
                            Description = "Disk version of Freelancer",
                            Comment = "Manual Install",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 1,
                            Name = "Freelancer 1.0",
                            Description = "Original Freelancer Version (eng)",
                            Comment = "Silent Install",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 2,
                            Name = "Freelancer 1.1",
                            Description = "Original Freelancer with Official path to version 1.1",
                            Comment = "Silent Install",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 3,
                            Name = "Freelancer 1.4",
                            Description = "Original Freelancer with Unofficial path to version 1.4 by Buck Danny",
                            Comment = "Silent Install",
                            InstallUri = "None"
                        }
                    }
                },
                new Entity.ModPack()
                {
                    Id = 1,
                    Name = "Freelancer RUS",
                    Description = "hihaha",
                    Mod = new List<Entity.Mod>() {
                        new Entity.Mod()
                        {
                            Id = 0,
                            Name = "Freelancer Disk Version",
                            Description = "Официальная версия с лицензионного диска",
                            Comment = "Ручная установка",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 1,
                            Name = "Freelancer Repack by R.G. Mechanics",
                            Description = "Репак от R.G. Механики",
                            Comment = "Ручная установка",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 2,
                            Name = "Freelancer RUS от Нового Диска",
                            Description = "Русская версия от издательства \"Новый диск\"",
                            Comment = "Тихая установка",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 3,
                            Name = "Freelancer RUS от Elite Games",
                            Description = "Русская версия от EliteGames",
                            Comment = "Тихая установка",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 4,
                            Name = "Freelancer RUS от Дядюшки Рисёча",
                            Description = "Русский интерфейс от Дядюшки Рисёча",
                            Comment = "Тихая установка",
                            InstallUri = "None"
                        }
                    }
                },
                new Entity.ModPack()
                {
                    Id = 2,
                    Name = "Freelancer Crossfire 2.0",
                    Description = "hihaha",
                    Mod = new List<Entity.Mod>() {
                        new Entity.Mod()
                        {
                            Id = 0,
                            Name = "Freelancer Crossfire",
                            Description = "Official Installer",
                            Comment = "",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 1,
                            Name = "Freelancer Crossfire 2.0",
                            Description = "Official Crossfire 2.0 with Silent Install",
                            Comment = "Тихая установка",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 2,
                            Name = "Freelancer Crossfire 2.0.1",
                            Description = "Latest Official version of Freelancer Crossfire 2.0 with Silent Install",
                            Comment = "Тихая установка",
                            InstallUri = "None"
                        }
                    }
                },
                 new Entity.ModPack()
                {
                    Id = 3,
                    Name = "Discovery Freelancer",
                    Description = "hihaha",
                    Mod = new List<Entity.Mod>() {
                        new Entity.Mod()
                        {
                            Id = 0,
                            Name = "Discovery Freelancer Launcher",
                            Description = "Official Version",
                            Comment = "No FLMM need",
                            InstallUri = "None"
                        },
                        new Entity.Mod()
                        {
                            Id = 1,
                            Name = "Discovery Freelancer Latest",
                            Description = "Official version with Silent Install and update inscluded",
                            Comment = "Тихая установка",
                            InstallUri = "None"
                        }
                    }
                },
                new Entity.ModPack()
                {
                    Id = 4,
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
                    Id = 5,
                    Name = "Discovery Freelancer International",
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
                },
                new Entity.ModPack()
                {
                    Id = 8,
                    Name = "Другая реальность",
                    Description = "hihaha",
                    Mod = new List<Entity.Mod>() {
                        new Entity.Mod()
                        {
                            Id = 0,
                            Name = "Другая реальность",
                            Description = "Мод \"Другая реальность\" для игры Freelancer от EliteGames",
                            Comment = "Тихая установка",
                            InstallUri = "None"
                        }
                    }
                },
                new Entity.ModPack()
                {
                    Id = 9,
                    Name = "Проклятие донгабаш",
                    Description = "hihaha",
                    Mod = new List<Entity.Mod>() {
                        new Entity.Mod()
                        {
                            Id = 0,
                            Name = "Проклятие донгабаш",
                            Description = "Мод \"Проклятие донгабаш\" для игры Freelancer от EliteGames",
                            Comment = "Тихая установка",
                            InstallUri = "None"
                        }
                    }
                },
                new Entity.ModPack()
                {
                    Id = 10,
                    Name = "EliteGames Main HQ",
                    Description = "hihaha",
                    Mod = new List<Entity.Mod>() {
                        new Entity.Mod()
                        {
                            Id = 0,
                            Name = "Freelancer 1.6 Multiplayer by Elite Games",
                            Description = "Клиент Freelancer для PVP сервера от Elite Games с неофициальным патчем до версии 1.6",
                            Comment = "Тихая установка",
                            InstallUri = "None"
                        }
                    }
                },
                new Entity.ModPack()
                {
                    Id = 11,
                    Name = "Nomad Legacy",
                    Description = "hihaha",
                    Mod = new List<Entity.Mod>() {
                        new Entity.Mod()
                        {
                            Id = 0,
                            Name = "Freelancer: Наследие Номадов",
                            Description = "Данная версия содержит последнюю стабильную версию с полностью готовыми и озвученными 6 миссиями, а также 2 дополнительными заданиями, которые вы можете запустить через меню загрузок.",
                            Comment = "Тихая установка",
                            InstallUri = "None"
                        }
                    }
                }
            };
            IC_ModPacks.ItemsSource = _modList;

        }

        private void GetMods_Click(object sender, RoutedEventArgs e)
        {
            Entity.Mod mod1 = _modList.FirstOrDefault(p => p.Name == "Freelancer Crossfire 2.0 RUS").Mod.FirstOrDefault(p => p.Name == "Руссификатор Сергея Дмитриева 2.0");
            Entity.Mod mod2 = _modList.FirstOrDefault(p => p.Name == "Discovery Freelancer").Mod.FirstOrDefault(p => p.Name == "Discovery Freelancer");
            MessageBox.Show(mod1.Name + "\n" + mod2.Name);
        }

        private void Dg_Mods_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && (sender as DataGrid).SelectedItem is Entity.Mod)
            {
                InstallWindow installWindow = new InstallWindow((sender as DataGrid).SelectedItem as Entity.Mod);
                installWindow.Show();

            }
        }
    }
}
