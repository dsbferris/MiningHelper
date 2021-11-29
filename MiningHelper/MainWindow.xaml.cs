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

namespace MiningHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            var args = Environment.GetCommandLineArgs();
            if (args.Contains("-run")){
                MessageBox.Show("Run");
            }

            

            InitializeComponent();
        }

        private void Label_Home_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Label_PowerPlan_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Label_MinerConfig_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Label_LogAnalyser_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
