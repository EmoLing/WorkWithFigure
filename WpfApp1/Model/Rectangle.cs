namespace WpfApp1.Model
{
    public class Rectangle : Figure
    {
        public override string Name { get; set; }
        public override string Color { get; set; }

        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public Rectangle(string Color, string Name, double width, double height) : base(Color, Name)
        {
            this.Name = Name;
            this.Color = Color;
            Width = width;
            Height = height;
        }

        public Rectangle(string Color, string Name, double width) : base(Color, Name)
        {
            this.Name = Name;
            this.Color = Color;
            Width = width;
            Height = width;
        }

    }
}