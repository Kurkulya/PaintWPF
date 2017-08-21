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
    /// Логика взаимодействия для PColor.xaml
    /// </summary>
    public partial class PColor : UserControl
    {
        public PColor()
        {
            InitializeComponent();
        }

        public XData data = null;

        private void SetColor(object sender, RoutedEventArgs e)
        {
            Button bt = sender as Button;
            data.color = bt.Background;
        }
    }
}
