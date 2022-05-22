using HH.DB.Models;
using HH.Settings;

namespace HH.Downloader
{
    internal static class Program
    {
        public static BasicSettings? Settings { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (File.Exists(BasicSettings.DefaultFileName))
            {
                MessageBox.Show(
                    $"Файл {BasicSettings.DefaultFileName} не найден.{Environment.NewLine}Создайте его и запустите приложение заново!");
                return;
            }

            Settings = SettingsLoader<BasicSettings>.Load();

            if (Settings == null)
            {
                MessageBox.Show($"Файл {BasicSettings.DefaultFileName} имеет неизвестный формат");
                return;
            }

            HhContext.Init(Settings.ConnectionString);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}