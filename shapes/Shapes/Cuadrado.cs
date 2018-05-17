using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.Shapes
{
    public class Cuadrado : Color
    {
        public Double Lado { get; set; }

        public Double Area
        {
            get
            {
                return Lado * Lado ;
            }
        }
        
    }
}
