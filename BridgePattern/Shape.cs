namespace BridgePattern
{
    public abstract class Shape
    {
        protected IDrawingShape shape;

        protected Shape(IDrawingShape shape)
        {
            this.shape = shape;
        }

        public abstract void draw();                                 
        public abstract void resizeByPercentage(double percentage);
    }
}
