using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourier_Series {
    class Graph {

        /// <summary>
        /// Stores all the y coordinates
        /// </summary>
        public List<float> yCoords { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_y"></param>
        public Graph() {

            //instantiates the list
            yCoords = new List<float>();
        }

        /// <summary>
        /// Adds a new y coordinate into the list
        /// </summary>
        /// <param name="toAdd">The y coordinate to add</param>
        public void AddPoint(int toAdd) {

            yCoords.Add(toAdd);

        }
    }
}
