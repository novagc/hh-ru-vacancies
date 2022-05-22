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
                    $"���� {BasicSettings.DefaultFileName} �� ������.{Environment.NewLine}�������� ��� � ��������� ���������� ������!");
                return;
            }

            Settings = SettingsLoader<BasicSettings>.Load();

            if (Settings == null)
            {
                MessageBox.Show($"���� {BasicSettings.DefaultFileName} ����� ����������� ������");
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