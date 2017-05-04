namespace BridgePattern
{
    public class Circle : Shape
    {
        private double x, y, radius;
        public Circle(double x, double y, double radius, IDrawingShape shape)
            : base(shape)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        
        public override void draw()
        {
            this.shape.DrawCircle(this.x, this.y, this.radius);
        }

        public override void resizeByPercentage(double percentage)
        {
            this.radius *= (1.0 + percentage / 100.0);
        }
    }
}
