using System;
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
using Settings = MiningHelper.Helper.Settings;
using System.Text.Json;

namespace MiningHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Views.PowerPlan? PowerPlanPage = null;
        Views.Home? HomePage = null;
        Views.MinerConfig? MinerConfigPage = null;
        Views.LogAnalyser? LogAnalyserPage = null;

        public MainWindow()
        {
            var args = Environment.GetCommandLineArgs();
            if (args.Contains("-run"))
            {
                if (Settings.AdminRequired)
                {
                    return;
                }
            }    

            InitializeComponent();
        }
        #region Navigation

        private void Button_Home_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(HomePage ??= (HomePage = new Views.Home()));
        }

        private void Button_PowerPlan_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(PowerPlanPage ??= (PowerPlanPage = new Views.PowerPlan()));
        }

        private void Button_MinerConfig_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(MinerConfigPage ??= (MinerConfigPage = new Views.MinerConfig()));
        }

        private void Button_LogAnalyser_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(LogAnalyserPage ??= new Views.LogAnalyser());
        }
        
        private void Button_NoAdminShortcut_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(LogAnalyserPage ??= new Views.LogAnalyser());
        }

        #endregion

    }
}
