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
using DataObjects;
using BusinessLogics;

namespace libCancerControls
{
    /// <summary>
    /// Interaction logic for usrControlPatientRegistration.xaml
    /// </summary>
    public partial class usrControlPatientRegistration : UserControl
    {
        public usrControlPatientRegistration()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btn_click_new_patient_clear_all(object sender, RoutedEventArgs e)
        {

        }

        public Patient GetPatientData() {

            Patient patient = new Patient();
            patient.Name = new_patient_patient_name.Text;
            patient.Fathers_name = new_patient_father_name.Text;
            patient.Sex = new_patient_sex.SelectedValue.ToString();
            patient.Age = new_patient_age.Text;
            patient.Religion = "NA";
            patient.Height = new_patient_height_cm.Text;
            patient.Weight = new_patient_weight.Text;
            patient.Address = new_patient_address.Text;
            patient.Contact_no = new_patient_contact_no.Text;
            patient.Reffered_id = new_patient_contact_no.Text;
            patient.Dtype = "NA"; // it will replace by disease details
            patient.Disese_id = "NA"; // it will replace by disease details

            return patient;
        }

        private void btn_click_new_patient_save(object sender, RoutedEventArgs e)
        {
          BLLPatient.Insert(this.GetPatientData());
        }

        private void body_surface_area_calculator(object sender, TextChangedEventArgs e)
        {
            double _patient_height_cm = 0;
            int _patient_weight_kg = 0;
            double _body_surface_area = 0;
            try
            {
                _patient_height_cm = Convert.ToDouble(this.new_patient_height_cm.Text);
            }
            catch
            { }

            try
            {
                _patient_weight_kg = Convert.ToInt32(this.new_patient_weight.Text);
            }
            catch
            { }

            _body_surface_area = Math.Sqrt((_patient_weight_kg + _patient_height_cm) / 3600);

            this.new_patient_bsa.Text = Convert.ToString(_body_surface_area) + " m^2";

        }

        private void foot_to_centimeter_converter(object sender, TextChangedEventArgs e)
        {
            int _patient_height_feet = 0;
            int _patient_height_inch = 0;
            try
            {
                _patient_height_feet = Convert.ToInt32(this.new_patient_height_feet.Text);

            }
            catch (SystemException)
            {

            }

            try
            {
                _patient_height_inch = Convert.ToInt32(this.new_patient_height_inch.Text);
            }
            catch
            {
            }

            double _patient_height_cm = (_patient_height_feet * 30.48) + (_patient_height_inch * 2.54);
            try
            {
                this.new_patient_height_cm.Text = Convert.ToString(_patient_height_cm);
            }
            catch (SystemException)
            {
            }

            this.body_surface_area_calculator(null, null);
        }

        private void centimeter_to_foot_converter(object sender, TextChangedEventArgs e)
        {
            //int _patient_height_feet = 0;
            //int _patient_height_inch = 0;
            //double _patient_height_cm = 0.00;

            //try
            //{
            //    _patient_height_cm = Convert.ToDouble(this.new_patient_height_cm.Text);
            //}
            //catch
            //{ }

            //_patient_height_feet = Convert.ToInt32(_patient_height_cm / 30.48);
            //_patient_height_inch = Convert.ToInt32(((_patient_height_cm / 30.48) - _patient_height_feet) * 12);

            //this.new_patient_height_feet.Text = Convert.ToString(_patient_height_feet);
            //this.new_patient_height_inch.Text = Convert.ToString(_patient_height_inch);

            this.body_surface_area_calculator(null, null);
        }
    }
}
