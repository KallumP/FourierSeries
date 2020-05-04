using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourier_Series {
    class Phasor {

        public float angleIncrement;
        public float angle;
        public float radius;
        public float diameter;
        public PointF center;
        public PointF tip = new PointF(0, 0);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_radius">Phasor radius</param>
        /// <param name="_center">The center point of the phasor</param>
        /// <param name="_angleIncrement">The angle at which to incremenat the phasor's angle</param>
        /// <param name="_angle">The starting angle of the phasor</param>
        public Phasor(float _radius, PointF _center, float _angleIncrement, float _angle) {

            angle = _angle;
            radius = _radius;
            diameter = radius * 2;
            center = _center;
            angleIncrement = _angleIncrement;
            tip.X = Convert.ToSingle(Math.Cos(Math.PI / 2 - angle)) * radius + center.X;
            tip.Y = Convert.ToSingle(Math.Sin(Math.PI / 2 - angle)) * radius + center.Y;
        }

        /// <summary>
        /// Incremenats the angle of the phasor
        /// </summary>
        public void IncreaseAngle() {

            //increments the angle by the assigned increment value
            angle += angleIncrement;

            //checks if the angle has gone past a full revolution (2Pi)
            if (angle > Math.PI / 2 + 2 * Math.PI)

                //removes a full revolution from the angle, setting it back to 0
                angle -= Convert.ToSingle(2 * Math.PI);

        }

        /// <summary>
        /// Rotates the tip coordinate of the phasor around the center point
        /// </summary>
        public void Rotate() {

            //sets the new value for the tip of the phasor
            tip.X = Convert.ToSingle(Math.Cos(Math.PI / 2 - angle)) * radius + center.X;
            tip.Y = Convert.ToSingle(Math.Sin(Math.PI / 2 - angle)) * radius + center.Y;
        }

        /// <summary>
        /// Sets the center point of the phasor
        /// </summary>
        /// <param name="newCenter"></param>
        public void UpdateCenter(PointF newCenter) {

            center = newCenter;
        }

        /// <summary>
        /// Returns the phasor's angle
        /// </summary>
        /// <returns>The phasor's angle in string form</returns>
        public string ReturnAngle() {

            return Convert.ToString(angle);
        }
    }
}
