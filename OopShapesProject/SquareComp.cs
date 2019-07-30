using System;
using System.Collections.Generic;
using System.Text;

namespace OopShapesProject {

    public class SquareComp {

        private Quad quad;

        public int GetPerimeter() {
            return (int)quad.GetPerimeter();
        }

        public int GetArea() {
            return (int)(quad.side1 * quad.side1);
        }

        public SquareComp(int sides) {
            quad = new Quad(sides, sides, sides, sides);
        }
    }
}
