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
using UILayer.ViewPanels.EquipmentPanels;

namespace Sportklubbhantering.ViewPanels
{
    /// <summary>
    /// Interaction logic for MenuePanel.xaml
    /// </summary>
    public partial class MenuPanel : Window
    {
        public MenuPanel()
        {
            InitializeComponent();
        }

        private void CreateWorkout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ManageMembers_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ManageEquipment_Click(object sender, RoutedEventArgs e)
        {
            EquipmentPanel equipmentPanel = new EquipmentPanel();
            equipmentPanel.Show();
            this.Close();

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
