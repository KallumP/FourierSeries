using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourier_Series
{
    class Graphs
    {
        private float y;
        public float radius = Convert.ToSingle(0.5);
        public float diameter;

        public Graphs(float _y)
        {
            y = _y;
            diameter = radius * 2;
        }


        public float getCoord()
        {
            return y;
        }
    }
}
