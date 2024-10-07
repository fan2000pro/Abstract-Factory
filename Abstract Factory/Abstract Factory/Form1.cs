using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private IShapeFactory _currentFactory;
        private IShape _currentShape;

        public MainForm()
        {
            InitializeComponent();
            comboBoxShapes.SelectedIndexChanged += ComboBoxShapes_SelectedIndexChanged;
            comboBoxColors.SelectedIndexChanged += ComboBoxColors_SelectedIndexChanged;

            comboBoxColors.Items.Add("Красный");
            comboBoxColors.Items.Add("Синий");
            comboBoxColors.Items.Add("Зелёный");
            comboBoxColors.Items.Add("Жёлтый");
            comboBoxColors.Items.Add("Фиолетовый");
            comboBoxColors.Items.Add("Оранжевый");
            comboBoxColors.Items.Add("Розовый");
            comboBoxColors.Items.Add("Бордовый");
            comboBoxColors.Items.Add("Серый");
            comboBoxShapes.Items.Add("Круг");
            comboBoxShapes.Items.Add("Квадрат");
            comboBoxShapes.Items.Add("Триугольник");

            comboBoxColors.SelectedIndex = 0;
            comboBoxShapes.SelectedIndex = 0;

            UpdateFactory();
            CreateShape();
        }

        private void ComboBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFactory();
            CreateShape();
            Invalidate();
        }

        private void ComboBoxShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateShape();
            Invalidate();
        }

        private void UpdateFactory()
        {
            string selectedColor = comboBoxColors.SelectedItem.ToString();
            switch (selectedColor)
            {
                case "Красный":
                    _currentFactory = new RedFactory();
                    break;
                case "Синий":
                    _currentFactory = new BlueFactory();
                    break;
                case "Зелёный":
                    _currentFactory = new GreenFactory();
                    break;
                case "Жёлтый":
                    _currentFactory = new YellowFactory();
                    break;
                case "Фиолетовый":
                    _currentFactory = new PurpleFactory();
                    break;
                case "Оранжевый":
                    _currentFactory = new OrangeFactory();
                    break;
                case "Розовый":
                    _currentFactory = new PinkFactory();
                    break;
                case "Бордовый":
                    _currentFactory = new BrownFactory();
                    break;
                case "Серый":
                    _currentFactory = new GrayFactory();
                    break;
            }
        }

        private void CreateShape()
        {
            if (comboBoxShapes.SelectedItem == null)
            {
                _currentShape = null;
                return;
            }

            string selectedShape = comboBoxShapes.SelectedItem.ToString();

            if (_currentFactory == null)
            {
                _currentShape = null;
                return;
            }

            switch (selectedShape)
            {
                case "Круг":
                    _currentShape = _currentFactory.CreateCircle();
                    break;
                case "Квадрат":
                    _currentShape = _currentFactory.CreateSquare();
                    break;
                case "Триугольник":
                    _currentShape = _currentFactory.CreateTriangle();
                    break;
                default:
                    _currentShape = null;
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _currentShape?.Draw(e.Graphics);
        }
    }

    public interface IShape
    {
        void Draw(Graphics g);
    }

    public class Circle : IShape
    {
        public Color Color { get; set; }

        public Circle(Color color)
        {
            Color = color;
        }

        public void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillEllipse(brush, 150, 150, 100, 100);
            }
        }
    }

    public class Square : IShape
    {
        public Color Color { get; set; }

        public Square(Color color)
        {
            Color = color;
        }

        public void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, 150, 150, 100, 100);
            }
        }
    }

    public class Triangle : IShape
    {
        public Color Color { get; set; }

        public Triangle(Color color)
        {
            Color = color;
        }

        public void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                Point[] points = { new Point(200, 150), new Point(150, 250), new Point(250, 250) };
                g.FillPolygon(brush, points);
            }
        }
    }

    public interface IShapeFactory
    {
        IShape CreateCircle();
        IShape CreateSquare();
        IShape CreateTriangle();
    }

    public class OrangeFactory : IShapeFactory
    {
        public IShape CreateCircle() => new Circle(Color.Orange);
        public IShape CreateSquare() => new Square(Color.Orange);
        public IShape CreateTriangle() => new Triangle(Color.Orange);
    }

    public class PinkFactory : IShapeFactory
    {
        public IShape CreateCircle() => new Circle(Color.Pink);
        public IShape CreateSquare() => new Square(Color.Pink);
        public IShape CreateTriangle() => new Triangle(Color.Pink);
    }

    public class BrownFactory : IShapeFactory
    {
        public IShape CreateCircle() => new Circle(Color.Brown);
        public IShape CreateSquare() => new Square(Color.Brown);
        public IShape CreateTriangle() => new Triangle(Color.Brown);
    }

    public class GrayFactory : IShapeFactory
    {
        public IShape CreateCircle() => new Circle(Color.Gray);
        public IShape CreateSquare() => new Square(Color.Gray);
        public IShape CreateTriangle() => new Triangle(Color.Gray);
    }

    public class GreenFactory : IShapeFactory
    {
        public IShape CreateCircle() => new Circle(Color.Green);
        public IShape CreateSquare() => new Square(Color.Green);
        public IShape CreateTriangle() => new Triangle(Color.Green);
    }

    public class YellowFactory : IShapeFactory
    {
        public IShape CreateCircle() => new Circle(Color.Yellow);
        public IShape CreateSquare() => new Square(Color.Yellow);
        public IShape CreateTriangle() => new Triangle(Color.Yellow);
    }

    public class PurpleFactory : IShapeFactory
    {
        public IShape CreateCircle() => new Circle(Color.Purple);
        public IShape CreateSquare() => new Square(Color.Purple);
        public IShape CreateTriangle() => new Triangle(Color.Purple);
    }

    public class RedFactory : IShapeFactory
    {
        public IShape CreateCircle() => new Circle(Color.Red);
        public IShape CreateSquare() => new Square(Color.Red);
        public IShape CreateTriangle() => new Triangle(Color.Red);
    }

    public class BlueFactory : IShapeFactory
    {
        public IShape CreateCircle() => new Circle(Color.Blue);
        public IShape CreateSquare() => new Square(Color.Blue);
        public IShape CreateTriangle() => new Triangle(Color.Blue);
    }
}
