namespace WpfApp1.Model
{
    public class Square : Rectangle
    {
        public override double Width { get; set; }
        public override double Height { get; set; }

        public Square(string Color, string Name, double width) : base(Color, Name, width)
        {
            Width = width;
            Height = width;
        }
    }
}