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

using DataObjects;
using BusinessLogics;

namespace libCancerControls.Views
{
    /// <summary>
    /// Interaction logic for UserControlDiseaseSelector.xaml
    /// </summary>
    public partial class UserControlDiseaseSelector : UserControl
    {
        public UserControlDiseaseSelector()
        {
            InitializeComponent();
        }

        public void LoadGridData(){
            BLLDisease.GetDisease();
        }

        private void txtICDKeywordSearch_KeyDown(object sender, KeyEventArgs e)
        {
            LoadGridData();
        }
    }
}
