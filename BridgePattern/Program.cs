namespace BridgePattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bridge pattern decouples abstraction from implementation.
             */

            var shapes = new Shape[]
                             {
                                 new Circle(1, 2, 3, new DrawingApi1()),
                                 new Circle(5, 7, 11, new DrawingApi2())
                             };

            foreach (var shape in shapes)
            {
                shape.resizeByPercentage(2.5);
                shape.draw();
            }

            Console.ReadLine();
        }
    }
}
