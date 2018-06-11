using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.Shapes
{
    public class Circle : IShape
    {

        public Double Radio { get; set; }
        
        public double Altura { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Base { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Area {
            get
            {
                return (Math.PI * (Math.Pow(Radio, 2)));
            }
            
        }

        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
