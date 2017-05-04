namespace BridgePattern
{
    using System;

    public class DrawingApi2 : IDrawingShape
    {
        public void DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine("API2:Circle at {0}:{1} radius {2}", x, y, radius);
        }
    }
}
