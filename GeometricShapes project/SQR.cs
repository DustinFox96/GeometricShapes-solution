using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes_project {
    class SQR {
        public int Side1 { get; set; }

        public int Perimeter() {
            return 4 * Side1;
        }

        public int Area() {
            return Side1 * Side1;
        }
        public SQR() {
        }
        public SQR(int s1) {
            Side1 = s1;

        }


    }
}
