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
    /// Interaction logic for UserControlStaging.xaml
    /// </summary>
    public partial class UserControlStaging : UserControl
    {
        public UserControlStaging()
        {
            InitializeComponent();
        }

        public Stage_M getStageMData()
        {
            Stage_M stage_m = new Stage_M();

            stage_m.Stage_m_name = txt_box_stage_name.Text;
            stage_m.Stage_m_desc = txt_box_stage_desc.Text;
            stage_m.Stage_m_disease_id = "N/A";

            return stage_m;
        }

        public Stage_N getStageNData()
        {
            Stage_N stage_n = new Stage_N();

            stage_n.Stage_n_name = txt_box_stage_name.Text;
            stage_n.Stage_n_desc = txt_box_stage_desc.Text;
            stage_n.Stage_n_disease_id = "N/A";

            return stage_n;
        }

        public Stage_T getStageTData()
        {
            Stage_T stage_t = new Stage_T();

            stage_t.Stage_t_name = txt_box_stage_name.Text;
            stage_t.Stage_t_desc = txt_box_stage_desc.Text;
            stage_t.Stage_t_disease_id = "N/A";

            return stage_t;
        }

        private void btn_stage_save_Click(object sender, RoutedEventArgs e)
        {
            switch (combo_stage_type.Text)
            {
                case "Stage T":
                    BLLStageAdmin.Insert(getStageTData());
                    break;
                case "Stage M":
                    BLLStageAdmin.Insert(getStageMData());
                    break;
                case "Stage N":
                    BLLStageAdmin.Insert(getStageNData());
                    break;
                default:
                    break;
            }
                 

        }
    }
}
