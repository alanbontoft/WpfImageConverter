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

namespace WpfImageConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DataModel _model;
        public MainWindow()
        {
            InitializeComponent();

            _model = new DataModel();

            _model.FillColor = "green";
            _model.Image = "";

            DataContext = _model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btnLast.IsEnabled ^= true;
        }

        private void btnSetImage_Click(object sender, RoutedEventArgs e)
        {
            _model.Image = txtColor.Text;
        }
    }

}
