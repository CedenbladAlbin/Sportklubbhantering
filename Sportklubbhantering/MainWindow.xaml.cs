using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Logiclayer;
using Sportklubbhantering.ViewModels;


namespace Sportklubbhantering
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

		private void addButton_Click(object sender, RoutedEventArgs e)
		{
            string name = inputTextBoxEmail.Text;
            string password = inputPasswordBox.Password;

            bool isValid = LogIn.CheckCredentials(name, password);

            if (isValid)
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private void CreateAccountBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateAccountTrainer CreateAccountTrainertrainerWindow = new CreateAccountTrainer();
            CreateAccountTrainertrainerWindow.Show();
            this.Close();

        }
    }
}