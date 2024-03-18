namespace work1
{
    //接口
    public interface IShape
    {
        double CalculateArea();
        bool IsValid();
    }
    //继承接口的抽象类
    public abstract class Shape : IShape
    {
        public abstract double CalculateArea();
        public abstract bool IsValid();
    }
    //矩形类
    public class Rectangle : Shape
    {
        public double weight { get; set; }
        public double high { get; set; }
        public Rectangle(double weight,double high) 
        {
            this.weight = weight;
            this.high = high;
        }
        public override double CalculateArea() 
        {
            return weight * high;
        }
        public override bool IsValid()
        {
            return weight > 0 && high > 0;
        }
    }
    //正方形类，继承矩形类
    public class Square : Rectangle {
        public Square(double a): base(a, a){}  //调用矩形的构造函数
    }
    //三角形类
    public class Triangle:Shape
    {
        public double Base { get; set; }
        public double High { get; set; }
   
        public Triangle(double Base, double High)
        {
            this.Base = Base;
            this.High = High;
        }
        public override double CalculateArea()
        {
            return 0.5*Base*High;
        }
        public override bool IsValid()
        {
            return Base>0 && High > 0;
        }
    }
    //工厂类
    public class ShapeFactory
    {
        private static Random random = new Random();  //用于确定参数的随机数
        
        public static IShape CreatShape(string shapeType)
        {
            switch(shapeType)
            {
                case "Rectangle":
                        return new Rectangle(random.NextDouble() * 10, random.NextDouble() * 10);
                case "Square":
                        return new Square(random.NextDouble() * 10);
                case "Triangle":
                        return new Triangle(random.NextDouble() * 10, random.NextDouble() * 10);
                default:
                    throw new ArgumentException("Invalid shape type.");
            }
        } 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            double sumArea = 0;
            Random random = new Random();       //用于确定形状的随机数
            for (int i = 0; i < 10; i++)
            {
                string shapeType = new string(new string[] { "Rectangle", "Square", "Triangle" }[random.Next(3)]);
                IShape shape = ShapeFactory.CreatShape(shapeType);

                if (shape.IsValid())
                {
                    shapes.Add(shape);
                    sumArea += shape.CalculateArea();
                }
                else
                {
                    Console.WriteLine("Invalid shape created and discarded.");
                }
            }
            Console.WriteLine("The sumArea is "+ sumArea);
            Console.WriteLine("The area of each shape:");
            foreach (IShape shape in shapes)
            {
                Console.WriteLine(shape.CalculateArea());
            }
        }
    }
}
