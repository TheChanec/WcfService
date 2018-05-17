using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.Shapes
{
    public class Rectangulo : Color
    {
        public Double Base { get; set; }

        public Double Altura { get; set; }

        public Double Area
        {
            get
            {
                return Base * Altura;
            }
        }
        
    }
}
