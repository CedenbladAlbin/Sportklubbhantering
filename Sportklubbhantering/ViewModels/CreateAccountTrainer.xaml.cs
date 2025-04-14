using Logiclayer;
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

namespace Sportklubbhantering.ViewModels
{
    /// <summary>
    /// Interaction logic for CreateAccountTrainer.xaml
    /// </summary>
    public partial class CreateAccountTrainer : Window
    {
        public CreateAccountTrainer()
        {
            InitializeComponent();
        }

        private void createAccount_Click(object sender, RoutedEventArgs e)
        {
            string name = inputTextBoxName.Text;
            string spec = inputTextBoxSpecialization.Text;
            string password = inputPasswordBox.Password;

            bool success = CreateAccount.CreateAccountTrainer(name, spec, password);

            if (success)
            {
                MessageBox.Show("Account created!");
            }
            else
            {
                MessageBox.Show("An account with that email already exists.");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }
    }
}
