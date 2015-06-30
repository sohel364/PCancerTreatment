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
    /// Interaction logic for UserControlRefferal.xaml
    /// </summary>
    public partial class UserControlRefferal : UserControl
    {
        public UserControlRefferal()
        {
            InitializeComponent();
        }


        public Refferal getRefferalData() {
            Refferal refferal = new Refferal();
            refferal.Reffered_by = txtName.Text.ToString().Trim();
            refferal.Details = txtDetails.Text.ToString().Trim();

            return refferal;
        }

        private void btn_click_Refferal_save(object sender, RoutedEventArgs e)
        {
            BLLRefferal.Insert(getRefferalData());
            MessageBox.Show("Inserted Successfully");
        }

    }
}
