namespace WpfApp1.Model
{
    public abstract class Figure
    {
       public abstract string Color { get; set; }
       public abstract string Name { get; set; }

       protected Figure(string Color, string Name)
       {
           this.Color = Color;
           this.Name = Name;
       }
    }
}