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

namespace WahidaHossainComp306Lab01
{
    /// <summary>
    /// Interaction logic for CreateBucket.xaml
    /// </summary>
    public partial class CreateBucket : Window
    {
        public CreateBucket()
        {
            InitializeComponent();
        }

        private void createback(object sender, RoutedEventArgs e)
        {
            MainWindow win2 = new MainWindow();
            win2.Show();
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            S3connection q = new S3connection();
            q.getList();
        }
    }
}
