using System;

namespace OopShapesProject {
    class Program {
        static void Main(string[] args) {

            var sqrcomp = new SquareComp(5);
            int p = sqrcomp.GetPerimeter();
            int a = sqrcomp.GetArea();
            Console.WriteLine($"The SqrComp perimeter is {p} and area is {a}");

            var quad1 = new Quad(5, 7, 13, 6);
            int perimeter = quad1.GetPerimeter();
            //var area1 = quad1.GetArea();
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
