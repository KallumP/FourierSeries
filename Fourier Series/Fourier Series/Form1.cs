using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Fourier_Series
{
    public partial class Form1 : Form
    {
        float speedIncrease = 2;
        int amountOfPhasorsToAdd = 0;
        float drawGap = Convert.ToSingle(1);
        bool takeValue = true;
        float startIncreaser = Convert.ToSingle(0.01);
        int circleSize = 7;
        List<Graphs> graph = new List<Graphs>();
        List<Phasor> phasors = new List<Phasor>();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkToAddNewPhasor();

            for (int i = 0; i < phasors.Count(); i++)
            {
                if (i != 0)
                    phasors[i].updateCenter(new Point(phasors[i - 1].tip.x, phasors[i - 1].tip.y));
                //moves each phasor so that it's center is aligned to the tip of its parent

                phasors[i].increaseAngle();
                //increases the angle of each phasor

                Invalidate();
                //redraws the screen

                phasors[i].rotate();
                //rotates each phasor
            }
            //loops through all the phasors

            addToGraph();
            //adds points to the graph

            labelUpdates();
            //updates the labels
        }
        //timer

        void labelUpdates()
        {
            count_lbl.Text = Convert.ToString(graph.Count());
            //shows the number of points in the graph

            angle_lbl.Text = phasors[0].returnAngle();
            //shows the angle of the first phasor

            phasorCount_lbl.Text = Convert.ToString(phasors.Count());
            //shows the amount of phasors being rotated

            phasorsToAdd_lbl.Text = Convert.ToString(amountOfPhasorsToAdd);
            //shows how many phasors need to be added on

            speedIncrease_lbl.Text = Convert.ToString(speedIncrease);
            //shows the speed increase

            graphStretch_lbl.Text = Convert.ToString(drawGap);
            //shows the stretch of the graph
        }
        //used to update all of the labels

        private void Form1_Load(object sender, EventArgs e)
        {
            phasors.Add(new Phasor(
                Convert.ToSingle(Height / circleSize * (4 / (1 * Math.PI))),
                new Point(Width / 4,
                Height / 2),
                startIncreaser,
                Convert.ToSingle(Math.PI / 2)));
            //adds the first phasor
        }
        //initial load condition

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int graphAligner = 0;

            foreach (Phasor p in phasors)
            {
                e.Graphics.DrawEllipse(Pens.Gray, p.center.x - p.radius, p.center.y - p.radius, p.diameter, p.diameter);
                //draws out each circle

                e.Graphics.DrawLine(Pens.Blue, p.center.x, p.center.y, p.tip.x, p.tip.y);
                //draws each phasor
            }

            if (graph.Count() != 0)
            {
                e.Graphics.DrawLine(Pens.Red,
                    phasors[phasors.Count() - 1].tip.x,
                    phasors[phasors.Count() - 1].tip.y,
                    Width / 2,
                    graph[graph.Count() - 1].getCoord());
            }
            //draws a line from the last phasor's tip to the first pointin the graph

            for (int i = (graph.Count() - 1); i > 0; i--)
            {
                e.Graphics.DrawLine(
                    Pens.Black,
                    Width / 2 + (graphAligner * drawGap),
                    graph[i].getCoord(),
                    Width / 2 + (graphAligner * drawGap + drawGap),
                    graph[i - 1].getCoord());
                //draws the lines between each point

                graphAligner++;
                //increases the aligner to make sure that the graph is drawn from left to right
            }
            ////draws the graph backwards

            if (Width / 2 + graphAligner * drawGap > Width)
                graph.RemoveAt(0);
            //removes the end of the graph

        }
        //paints the screen

        public void addToGraph()
        {
            if (takeValue == true)
            {
                graph.Add(new Graphs(phasors[phasors.Count() - 1].tip.y));
                //adds a new point to the graph per tick at the y coord of the last phasor

                takeValue = false;
            }
            else
            {
                takeValue = true;
            }
            //takes every other value
        }
        //adds values to the graph

        private void addPhasor_btn_Click(object sender, EventArgs e)
        {
            amountOfPhasorsToAdd++;
        }
        //notes how many phasors to add on at the end of the revolution

        public void addPhasor(float _newAngle)
        {
            for (int i = 0; i < amountOfPhasorsToAdd; i++)
            {
                phasors.Add(new Phasor(
                    Convert.ToSingle(Height / circleSize * (4 / ((1 + phasors.Count * 2) * Math.PI))),
                    //gets the new radius based off the last one's radius
                    new Point(phasors[phasors.Count() - 1].center.x,
                    phasors[phasors.Count() - 1].center.y - phasors[phasors.Count() - 1].radius),
                    //gets the center of the new phasor from the tip of the last phasor
                    phasors[0].increaser * (phasors.Count() * speedIncrease + 1),
                    //gets the new phasors rotation speed from the first phasor's speed
                    _newAngle));
                //adds a new phasor to the end of the smallest phasor


            }
        }
        //adds on a new phasor

        public void checkToAddNewPhasor()
        {
            if (phasors[0].angle > Math.PI / 2 && phasors[0].angle < Math.PI / 2 + 2 * startIncreaser)
            {
                addPhasor(Convert.ToSingle(Math.PI / 2));
                //adds on a phasor when the right angle has been reached

                amountOfPhasorsToAdd = 0;
                //resets the amount to add
            }
            else if (phasors[0].angle > 3 * Math.PI / 2 && phasors[0].angle < 3 * Math.PI / 2 + 2 * startIncreaser)
            {
                addPhasor(Convert.ToSingle(3 * Math.PI / 2));
                //adds on a phasor when the right angle has been reached

                amountOfPhasorsToAdd = 0;
                //resets the amount to add
            }
            //if statements to check to make sure it is adding on at the right time
            //this is so that the right angle can be given to the new phasor being added
        }
        //checks to see if the new phasors should be added on

        private void removePhasor_btn_Click(object sender, EventArgs e)
        {
            if (phasors.Count > 1)
                phasors.RemoveAt(phasors.Count - 1);
        }
        //removes the smallest phasor

        private void increaseSpeed_btn_Click(object sender, EventArgs e)
        {
            speedIncrease += Convert.ToSingle(1);
        }
        private void decreaseSpeed_btn_Click(object sender, EventArgs e)
        {
            speedIncrease -= Convert.ToSingle(1);
        }
        //changes the rotation speed of the new phasors

        private void button1_Click(object sender, EventArgs e)
        {
            drawGap += Convert.ToSingle(0.5);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            drawGap -= Convert.ToSingle(0.5);
        }
        //changes the stretch of the graph
    }
    public class Point
    {
        public float x;
        public float y;

        public Point(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
    }
    //point variable class 
}
