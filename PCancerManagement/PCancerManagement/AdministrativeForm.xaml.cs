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
using System.Windows.Shapes;

namespace PCancerManagement
{
    /// <summary>
    /// Interaction logic for AdministrativeForm.xaml
    /// </summary>
    public partial class AdministrativeForm : Window
    {
        public AdministrativeForm()
        {
            InitializeComponent();
        }


        internal void LoadUserControl(UIElement element)
        {
            UserControl usrControl = (UserControl)element;   
            this.myStack.Children.Clear();
            this.myStack.Children.Add(usrControl);
            this.Title = usrControl.Name;
        }
    }
}
