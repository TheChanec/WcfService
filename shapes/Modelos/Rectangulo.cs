using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.Shapes
{
    public class Rectangulo : IShape
    {
        public double Altura { get; set; }
        public double Base { get; set; }

        public double Area
        {
            get
            {
                return Altura * Base;
            }
        }

        public string Color { get; set; }
    }
}
