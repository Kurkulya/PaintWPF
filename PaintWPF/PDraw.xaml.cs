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
    /// Логика взаимодействия для PDraw.xaml
    /// </summary>
    public partial class PDraw : UserControl
    {
        public PDraw()
        {
            InitializeComponent();
        }

        public XData data = null;
        double x = 0;
        double y = 0;

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            x = e.GetPosition(this).X;
            y = e.GetPosition(this).Y;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                pDraw.Children.Add(CreateLine(data.color, data.width, x, y, e.GetPosition(this).X, e.GetPosition(this).Y));
                x = e.GetPosition(this).X;
                y = e.GetPosition(this).Y;           
            }
        }

        private Line CreateLine(Brush color, int lineWidth, double x1, double y1, double x2, double y2)
        {
            Line line = new Line();

            line.Stroke = color;
            line.SnapsToDevicePixels = true;
            line.StrokeThickness = lineWidth;

            line.X1 = x1;
            line.X2 = x2;
            line.Y1 = y1;
            line.Y2 = y2;

            return line;
        }
    }
}
