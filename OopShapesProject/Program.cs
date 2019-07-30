using System;

namespace OopShapesProject {
    class Program {
        static void Main(string[] args) {

            var quad1 = new Quad(5, 7, 13, 6);
            var perimeter = quad1.GetPerimeter();
            Console.WriteLine($"The quad perimeter is {perimeter}");

            var rect1 = new Rect(5, 13);
            perimeter = rect1.GetPerimeter();
            var area = rect1.GetArea();
            Console.WriteLine($"The rect perimeter is {perimeter}; area is {area}");

            var sqr1 = new Square(7);
            perimeter = sqr1.GetPerimeter();
            area = sqr1.GetArea();
            Console.WriteLine($"The square perimeter is {perimeter}; area is {area}");
        }
    }
}
