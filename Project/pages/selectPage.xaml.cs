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

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class selectPage : Window
    {
        public selectPage()
        {
            InitializeComponent();

        }

        private void buttonEge(object sender, RoutedEventArgs e)
        {
            var newForm = new egePage(); 
            newForm.Show(); 
            this.Close(); 
        }
        private void buttonSchool(object sender, RoutedEventArgs e)
        {
            var newForm = new schoolPage();
            newForm.Show();
            this.Close();
        }
        private void buttonOlymp(object sender, RoutedEventArgs e)
        {
            var newForm = new olympPage();
            newForm.Show();
            this.Close();
        }
    }
 }
