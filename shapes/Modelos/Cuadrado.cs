using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.Shapes
{
    public class Cuadrado : IShape 
    {
        public Cuadrado()
        {
                
        }

        public Cuadrado(double altura, double @base)
        {
            Altura = altura;
            Base = @base;
        }

        public double Altura { get; set; }
        public double Base { get; set; }
        public double Area {
            get
            {
                return Altura * Altura;
            }
        }
        public string Color { get; set; }
    }
}
