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

namespace WpfApp3
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

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            string voorNaam;
            string achterNaam;

            if (double.TryParse(txtVerdiensten.Text, out double verdiensten) && !string.IsNullOrEmpty(txtAchternaam.Text) && !string.IsNullOrEmpty(txtVoornaam.Text))
            {
                voorNaam = txtVoornaam.Text;
                achterNaam = txtAchternaam.Text;
                txtResult.Text += $"{achterNaam,-30} {voorNaam,-30} {verdiensten + "€",-30}" + Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Gelieve alles in te vullen! Verdiensten in cijfers aub! ");
            }

            txtVoornaam.Text = "";
            txtAchternaam.Text = "";
            txtVerdiensten.Text = "";
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
