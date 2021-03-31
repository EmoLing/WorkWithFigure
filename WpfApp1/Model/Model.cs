using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using Prism.Mvvm;

namespace WpfApp1.Model
{
    public class Model : BindableBase
    {
        private readonly ObservableCollection<Figure> _figures = new ObservableCollection<Figure>();
        public ReadOnlyObservableCollection<Figure> Figures;

        public Model()
        {
            Figures = new ReadOnlyObservableCollection<Figure>(_figures);
        }

        public UIElement DrawFigure(double width, double height, string name, string color)
        {
            switch (name)
            {
                case "Эллипс":
                { 
                    _figures.Add(new Ellipse(color, name, width, height));
                    var ellipse = new System.Windows.Shapes.Ellipse();
                    ellipse.Width = width;
                    ellipse.Height = height;
                    ellipse.VerticalAlignment = VerticalAlignment.Top;
                    ellipse.Fill = Brushes.Green;
                    return ellipse;
                }
                case "Круг":
                {
                    _figures.Add(new Circle(color, name, width));
                    var circle = new System.Windows.Shapes.Ellipse();
                    circle.Width = width;
                    circle.Height = width;
                    circle.VerticalAlignment = VerticalAlignment.Top;
                    circle.Fill = Brushes.Green;
                    return circle;
                }
                case "Квадрат":
                {
                    _figures.Add(new Square(color, name, width));
                    var square = new System.Windows.Shapes.Rectangle();
                    square.Width = width;
                    square.Height = width;
                    square.VerticalAlignment = VerticalAlignment.Top;
                    square.Fill = Brushes.Green;
                    return square;
                    }
                case "Прямоугольник":
                {
                    _figures.Add(new Rectangle(color, name, width, height));
                    var square = new System.Windows.Shapes.Rectangle();
                    square.Width = width;
                    square.Height = height;
                    square.VerticalAlignment = VerticalAlignment.Top;
                    square.Fill = Brushes.Green;
                    return square;
                }
                default: return null;
            }


        }
    }
}