using BusinessLayer;
using EntityLayer;
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

namespace UILayer.ViewPanels.EquipmentPanels
{
    /// <summary>
    /// Interaction logic for AddEquipmentPanel.xaml
    /// </summary>
    public partial class AddEquipmentPanel : Window
    {

        private EquipmentService _equipmentService;
        private Equipment _currentEquipment;

        public AddEquipmentPanel(Equipment equipment = null)
        {
            InitializeComponent();

            _equipmentService = new EquipmentService();

            if (equipment != null)
            {
                _currentEquipment = equipment;
                EquipmentNameTextBox.Text = equipment.equipment_name;
                CategoryTextBox.Text = equipment.category;
                ConditionTextBox.Text = equipment.condition.ToString();
                AvailableCountTextBox.Text = equipment.available_count.ToString();
            }
            else
            {
                _currentEquipment = new Equipment();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EquipmentNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(CategoryTextBox.Text) ||
                !int.TryParse(ConditionTextBox.Text, out int condition) ||
                !int.TryParse(AvailableCountTextBox.Text, out int availableCount))
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }
            _currentEquipment.equipment_name = EquipmentNameTextBox.Text;
            _currentEquipment.category = CategoryTextBox.Text;
            _currentEquipment.condition = condition;
            _currentEquipment.available_count = availableCount;

            if (_currentEquipment.equipment_ID == 0)
            {
                _equipmentService.CreateEquipment(_currentEquipment);
            }
            else
            {
                _equipmentService.UpdateEquipment(_currentEquipment);
            }

            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

