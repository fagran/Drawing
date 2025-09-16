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
using static System.Formats.Asn1.AsnWriter;

namespace Drawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Triangle tr;
        Rectangle rec;
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();

            

        }

        public void DrawLine(Point2D p1, Point2D p2)
        {
            //Создание новой линии
            Line line = new Line();
            //Цвет и толщина линии
            line.Stroke = Brushes.Red;
            line.StrokeThickness = 3;
            //Установка координат линии из координат точек Point2D
            line.X1 = p1.X;
            line.Y1 = p1.Y;
            line.X2 = p2.X;
            line.Y2 = p2.Y;
            //Добавление линии в Canvas
            Scene.Children.Add(line);
        }
        public void DrawTriangle(object sender, RoutedEventArgs e)
        {
            ClearScene();
            Point2D p1 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p2 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p3 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            tr = new Triangle(p1, p2, p3);
            //Отрисовка треугольника с помощью функции отрисовки линии
            DrawLine(tr.P1, tr.P2);
            DrawLine(tr.P2, tr.P3);
            DrawLine(tr.P3, tr.P1);
        }

        public void DrawRect(object sender, RoutedEventArgs e)
        {
            ClearScene();
            Point2D p1 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
            Point2D p2 = new Point2D(rnd.Next(0, (int)Scene.Width), p1.Y);
            Point2D p3 = new Point2D(p1.X, rnd.Next(0, (int)Scene.Height));
            Point2D p4 = new Point2D(p2.X, p3.Y);
            rec = new Rectangle(p1, p2, p3,p4);
            //Отрисовка прямоугольника с помощью функции отрисовки линии
            DrawLine(rec.P1, rec.P2);
            DrawLine(rec.P1, rec.P3);
            DrawLine(rec.P3, rec.P4);
            DrawLine(rec.P2, rec.P4);
        }

        public void DrawSqr(object sender, RoutedEventArgs e)
        {
            ClearScene();
            Point2D p1 = new Point2D(0, 0);
            Point2D p2 = new Point2D(rnd.Next(0, (int)Scene.Width), 0);
            Point2D p3 = new Point2D(0, p2.X);
            Point2D p4 = new Point2D(p2.X, p3.Y);
            rec = new Rectangle(p1, p2, p3, p4);
            //Отрисовка прямоугольника с помощью функции отрисовки линии
            DrawLine(rec.P1, rec.P2);
            DrawLine(rec.P1, rec.P3);
            DrawLine(rec.P3, rec.P4);
            DrawLine(rec.P2, rec.P4);
        }
        public void ClearScene()
        {
            //Очистка Canvas от всех объектов
            Scene.Children.Clear();
        }

    }
}