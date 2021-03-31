namespace WpfApp1.Model
{
    public class Ellipse : Figure
    {
        public override string Name { get; set; }
        public override string Color { get; set; }

        public virtual double RSmall { get; set; }
        public virtual double RBig { get; set; }

        public Ellipse(string Color, string Name, double rSmall, double rBig) : base(Color, Name)
        {
            this.Name = Name;
            this.Color = Color;
            RSmall = rSmall;
            RBig = rBig;
        }

        protected Ellipse(string Color, string Name, double rBig) : base(Color, Name)
        {
            this.Name = Name;
            this.Color = Color;
            RBig = rBig;
        }
    }
}