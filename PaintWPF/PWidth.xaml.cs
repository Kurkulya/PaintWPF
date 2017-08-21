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

namespace PaintWPF
{
    /// <summary>
    /// Логика взаимодействия для PWidth.xaml
    /// </summary>
    public partial class PWidth : UserControl
    {
        public PWidth()
        {
            InitializeComponent();
            listWidth.Items.Add(1);
            listWidth.Items.Add(5);
            listWidth.Items.Add(10);
            listWidth.Items.Add(15);
            listWidth.Items.Add(20);
        }

        public XData data = null;

        private void SetWidth(object sender, SelectionChangedEventArgs e)
        {
            data.width = Convert.ToInt32(listWidth.SelectedItem);
        }
    }
}
