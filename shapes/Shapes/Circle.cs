using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.Shapes
{
    public class Circle : Color
    {

        public Double Radio { get; set; }

        public Double Area
        {
            get
            {
                return (Math.PI * (Math.Pow(Radio, 2)));
            }
        }

        
    }
}
