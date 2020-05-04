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

namespace Fourier_Series {
    public partial class Form1 : Form {

        float speedIncrease = 2;
        int amountOfPhasorsToAdd = 0;
        float drawGap = Convert.ToSingle(1);
        bool takeValue = true;
        float startIncreaser = Convert.ToSingle(0.01);
        int circleSize = 7;


        List<Graphs> graph = new List<Graphs>();
        List<Phasor> phasors = new List<Phasor>();

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// Tick event for the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) {

            //checks if there are new phasors to add
            checkToAddNewPhasor();

            ///loops through each phasor
            for (int i = 0; i < phasors.Count(); i++) {

                //if the current loop isn't 1
                if (i != 0)

                    //moves each phasor so that it's center is aligned to the tip of its parent
                    phasors[i].UpdateCenter(new PointF(phasors[i - 1].tip.X, phasors[i - 1].tip.Y));

                //increases the angle of each phasor
                phasors[i].IncreaseAngle();

                //redraws the screen
                Invalidate();

                //rotates each phasor
                phasors[i].Rotate();
            }

            //adds points to the graph
            AddToGraph();

            //updates the labels
            LabelUpdates();
        }

        /// <summary>
        /// Updates all the labels
        /// </summary>
        void LabelUpdates() {

            //shows the number of points in the graph
            count_lbl.Text = Convert.ToString(graph.Count());

            //shows the angle of the first phasor
            angle_lbl.Text = phasors[0].ReturnAngle();

            //shows the amount of phasors being rotated
            phasorCount_lbl.Text = Convert.ToString(phasors.Count());

            //shows how many phasors need to be added on
            phasorsToAdd_lbl.Text = Convert.ToString(amountOfPhasorsToAdd);

            //shows the speed increase
            speedIncrease_lbl.Text = Convert.ToString(speedIncrease);

            //shows the stretch of the graph
            graphStretch_lbl.Text = Convert.ToString(drawGap);
        }

        /// <summary>
        /// Form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e) {

            //adds the first phasor
            phasors.Add(new Phasor(
                (float)(Height / circleSize * (4 / (1 * Math.PI))),
                new PointF(Width / 4, Height / 2),
                startIncreaser,
                (float)Math.PI / 2));
        }

        /// <summary>
        /// Form paint event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e) {

            //loops through each phasor
            foreach (Phasor p in phasors) {

                //draws out each circle (traced by the tip of the phasor)
                e.Graphics.DrawEllipse(Pens.Gray, p.center.X - p.radius, p.center.Y - p.radius, p.diameter, p.diameter);

                //draws each phasor
                e.Graphics.DrawLine(Pens.Blue, p.center.X, p.center.Y, p.tip.X, p.tip.Y);
            }

            //checks if there are any graph points to draw to
            if (graph.Count() != 0) {

                //draws a line from the last phasor's tip to the first pointion the graph
                e.Graphics.DrawLine(Pens.Red,
                    phasors[phasors.Count() - 1].tip.X,
                    phasors[phasors.Count() - 1].tip.Y,
                    Width / 2,
                    graph[graph.Count() - 1].getCoord());
            }

            //keeps track of the x coordinate to draw the graph point
            int graphXCoord = 0;

            //loops through each of the graph points backwards (excluding the 0 index)
            for (int i = graph.Count() - 1; i > 0; i--) {

                //draws a line from current point to the previous point
                e.Graphics.DrawLine(
                    Pens.Black,
                    Width / 2 + (graphXCoord * drawGap),
                    graph[i].getCoord(),
                    Width / 2 + (graphXCoord * drawGap + drawGap),
                    graph[i - 1].getCoord());

                //increases the x coodinate to make sure that the graph is drawn from left to right
                graphXCoord++;
            }

            //Checks if the final graph point is outside the buonds of the window
            if (Width / 2 + graphXCoord * drawGap > Width)

                //removes that graph point
                graph.RemoveAt(0);
        }

        /// <summary>
        /// Adds a new value to the graph
        /// </summary>
        public void AddToGraph() {

            //checks if the value should be taken (so that only every other value is taken)
            if (takeValue == true) {

                //adds a new point to the graph per tick at the Y coord of the last phasor
                graph.Add(new Graphs(phasors[phasors.Count() - 1].tip.Y));

                takeValue = false;
            } else {

                takeValue = true;
            }
        }

        /// <summary>
        /// Add phasor click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPhasor_btn_Click(object sender, EventArgs e) {

            //increments how many phasors should be added at the end of the revolution
            amountOfPhasorsToAdd++;
        }

        /// <summary>
        /// Adds on a new phasor
        /// </summary>
        /// <param name="_newAngle">The angle at which to add the phasor</param>
        public void AddPhasor(float _newAngle) {

            for (int i = 0; i < amountOfPhasorsToAdd; i++)

                //adds a new phasor to the end of the smallest phasor
                phasors.Add(new Phasor(

                    //gets the new radius based off the last one's radius
                    (float)(Height / circleSize * (4 / ((1 + phasors.Count * 2) * Math.PI))),

                    //gets the center of the new phasor from the tip of the last phasor
                    new PointF(phasors[phasors.Count() - 1].center.X, phasors[phasors.Count() - 1].center.Y - phasors[phasors.Count() - 1].radius),

                    //gets the new phasors rotation speed from the first phasor's speed
                    phasors[0].angleIncrement * (phasors.Count() * speedIncrease + 1),

                    _newAngle));
        }

        /// <summary>
        /// Checks to see if the new phasor should be added on
        /// </summary>
        public void checkToAddNewPhasor() {

            //checks which side the phasor is being added on at (all the way to the right or left)
            if (phasors[0].angle > Math.PI / 2 && phasors[0].angle < Math.PI / 2 + 2 * startIncreaser) {
                
                //adds on a phasor when the right angle has been reached
                AddPhasor((float)(Math.PI / 2));

                //resets the amount to add
                amountOfPhasorsToAdd = 0;
            
            } else if (phasors[0].angle > 3 * Math.PI / 2 && phasors[0].angle < 3 * Math.PI / 2 + 2 * startIncreaser) {
            
                //adds on a phasor when the right angle has been reached
                AddPhasor((float)(3 * Math.PI / 2));

                //resets the amount to add
                amountOfPhasorsToAdd = 0;
            }
        }

        /// <summary>
        /// Removes the last phasor from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removePhasor_btn_Click(object sender, EventArgs e) {
            if (phasors.Count > 1)
                phasors.RemoveAt(phasors.Count - 1);
        }

        /// <summary>
        /// Increases the rotation of the next phasor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void increaseSpeed_btn_Click(object sender, EventArgs e) {
            speedIncrease += Convert.ToSingle(1);
        }

        /// <summary>
        /// Decreases the rotation of the next phasor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void decreaseSpeed_btn_Click(object sender, EventArgs e) {
            speedIncrease -= Convert.ToSingle(1);
        }

        /// <summary>
        /// Increases the gap between the graph points
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            drawGap += Convert.ToSingle(0.5);
        }

        /// <summary>
        /// Decreases the stretch of the graph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) {
            drawGap -= Convert.ToSingle(0.5);
        }
    }
}
