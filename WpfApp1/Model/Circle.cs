namespace WpfApp1.Model
{
    public class Circle : Ellipse
    {
        public override double RBig { get; set; }
        public override double RSmall { get; set; }

        public Circle(string Color, string Name, double rBig) : base(Color, Name, rBig)
        {
            RBig = rBig;
            RSmall = rBig;
        }
    }
}