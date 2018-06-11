using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.Shapes
{
    public interface IShape : IColor
    {
        double Altura { get; set; }
        double Base { get; set; }

        double Area { get; }


    }
}
