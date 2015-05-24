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
using System.Text.RegularExpressions;
using BusinessLogics;

namespace AvalonDockTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BusinessLogics.SetDataBaseConnectionString.SetDataBaseConnection();
            libCancerControls.usrControlDiagnosis usr_control_diagnosis = (libCancerControls.usrControlDiagnosis)this.FindName("user_control_diagnosis");
            Button btn_stage_histopathology = (Button)usr_control_diagnosis.FindName("btn_stage_histopathology");
            Button btn_stage_cytology = (Button)usr_control_diagnosis.FindName("btn_stage_cytology");

            btn_stage_histopathology.Click += new RoutedEventHandler(btn_click_histology);
            btn_stage_cytology.Click += new RoutedEventHandler(btn_click_cytology);
        }

        private void btn_click_cytology(object sender, RoutedEventArgs e)
        {
            PCancerManagement.StageSelector stageSelector = new PCancerManagement.StageSelector();
            stageSelector.ShowDialog();
        }

        private void btn_click_histology(object sender, RoutedEventArgs e)
        {
            PCancerManagement.StageSelector stageSelector = new PCancerManagement.StageSelector();
            stageSelector.ShowDialog();
        }


        private void MenuItemStagingClickEvent(object sender, RoutedEventArgs e)
        {
            PCancerManagement.AdministrativeForm adminForm = new PCancerManagement.AdministrativeForm();
            libCancerControls.Views.UserControlStaging usrCntrl = new libCancerControls.Views.UserControlStaging();
            adminForm.LoadUserControl(usrCntrl);
            adminForm.ShowDialog();
        }

        private void MenuItemRefferalClickEvent(object sender, RoutedEventArgs e)
        {
            PCancerManagement.AdministrativeForm adminForm = new PCancerManagement.AdministrativeForm();
            libCancerControls.Views.UserControlRefferal usrCntrl = new libCancerControls.Views.UserControlRefferal();
            adminForm.LoadUserControl(usrCntrl);
            adminForm.ShowDialog();
        }

    }
}
