namespace BridgePattern
{
    using System;

    public class DrawingApi1 : IDrawingShape
    {
        public void DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine("API1:Circle at {0}:{1} radius {2}", x, y, radius);
        }
    }
}
