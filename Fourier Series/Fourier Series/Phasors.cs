using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourier_Series
{
    class Phasor
    {
        public float increaser;
        public float angle;
        public float radius;
        public float diameter;
        public Point center;
        public Point tip = new Point(0, 0);
        public float angleAdded = 0;

        public Phasor(float _radius, Point _center, float _increaser, float _angle)
        {
            angle = _angle;
            radius = _radius;
            diameter = radius * 2;
            center = _center;
            increaser = _increaser;
            tip.x = Convert.ToSingle(Math.Cos(Math.PI / 2 - angle)) * radius + center.x;
            tip.y = Convert.ToSingle(Math.Sin(Math.PI / 2 - angle)) * radius + center.y;
        }
        //constructor

        public void increaseAngle()
        {
            angle += increaser;
            angleAdded += increaser;

            if (angle > Math.PI / 2 + 2 * Math.PI)
                angle -= Convert.ToSingle(2 * Math.PI);
            //sets the angle back to Pi/2 after each revolution
            //no change in graph or rotation, because it is just removing a whole revolution from the angle
            //just used for angle checking
        }
        //increases the angle of the phasor

        public void rotate()
        {
            tip.x = Convert.ToSingle(Math.Cos(Math.PI / 2 - angle)) * radius + center.x;
            tip.y = Convert.ToSingle(Math.Sin(Math.PI / 2 - angle)) * radius + center.y;
            //sets the new value of the tip of the phasor
        }
        //rotates the phasor

        public void updateCenter(Point newCenter)
        {
            center = newCenter;
        }
        //sets the center for phasors that are connected to larger phasors

        public string returnAngle()
        {
            return Convert.ToString(angle);
        }
        //returns the angle of a phasor
    }
}
