using BusinessLayer;
using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using UILayer.ViewPanels.EquipmentPanels;

namespace UILayer.ViewPanels.EquipmentPanels
{
    public partial class EquipmentPanel : Window
    {
        private readonly EquipmentService _equipmentService = new();
        private ObservableCollection<Equipment> EquipmentList = new();

        public EquipmentPanel()
        {
            InitializeComponent();
            LoadEquipment();
            EquipmentListView.ItemsSource = EquipmentList;
        }

        private void LoadEquipment()
        {
            var equipments = _equipmentService.GetAllEquipment();
            EquipmentList = new ObservableCollection<Equipment>(equipments);
            EquipmentListView.ItemsSource = EquipmentList;
        }

        private void NewEquipment_Click(object sender, RoutedEventArgs e)
        {
            AddEquipmentPanel addWindow = new AddEquipmentPanel();
            if (addWindow.ShowDialog() == true)
            {
                LoadEquipment();
            }
        }
        private void DeleteEquipment_Click(object sender, RoutedEventArgs e)
        {
            var selectedEquipment = EquipmentListView.SelectedItem as Equipment;
            if (selectedEquipment != null)
            {
                _equipmentService.DeleteEquipment(selectedEquipment.equipment_ID);
                EquipmentList.Remove(selectedEquipment);
            }
        }

        private void EditEquipment_Click(object sender, RoutedEventArgs e)
        {
            var selectedEquipment = EquipmentListView.SelectedItem as Equipment;
            if (selectedEquipment != null)
            {
                AddEquipmentPanel editWindow = new AddEquipmentPanel(selectedEquipment);
                if (editWindow.ShowDialog() == true)
                {
                    LoadEquipment();
                }
            }
        }


        private void EquipmentListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var isSelected = EquipmentListView.SelectedItem != null;
            EditButton.IsEnabled = isSelected;
            DeleteButton.IsEnabled = isSelected;
        }
    }
}