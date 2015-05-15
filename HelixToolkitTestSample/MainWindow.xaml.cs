using HelixToolkit.Wpf;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelixToolkitTestSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var image = new BitmapImage(new Uri("pack://application:,,,/Images/grayscale28.jpg"));
            var brush = new ImageBrush(image);

            brush.Transform = new RotateTransform(90, 0.5, 0.5);

            var material = new DiffuseMaterial(brush);
            var rect = new RectangleVisual3D() { Width = 30, Length = 40, Material = material };

            viewport3d.Children.Add(rect);
        }
    }
}
