using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace FlLauncher
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App() {
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Произошла критическая ошибка. Приложение постарается сохранить свою работу, но результат выполнения процесса не гарантируется. Рекомендуем повторить попытку заново.", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
