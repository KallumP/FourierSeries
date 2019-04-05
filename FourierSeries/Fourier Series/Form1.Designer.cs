namespace Fourier_Series
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.count_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.angle_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phasorCount_lbl = new System.Windows.Forms.Label();
            this.addPhasor_btn = new System.Windows.Forms.Button();
            this.removePhasor_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.phasorsToAdd_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.speedIncrease_lbl = new System.Windows.Forms.Label();
            this.increaseSpeed_btn = new System.Windows.Forms.Button();
            this.decreaseSpeed_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.graphStretch_lbl = new System.Windows.Forms.Label();
            this.graphIncrease_btn = new System.Windows.Forms.Button();
            this.graphDecrease_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.Location = new System.Drawing.Point(85, 9);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(35, 13);
            this.count_lbl.TabIndex = 0;
            this.count_lbl.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Graph Points: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Angle:";
            // 
            // angle_lbl
            // 
            this.angle_lbl.AutoSize = true;
            this.angle_lbl.Location = new System.Drawing.Point(85, 33);
            this.angle_lbl.Name = "angle_lbl";
            this.angle_lbl.Size = new System.Drawing.Size(35, 13);
            this.angle_lbl.TabIndex = 2;
            this.angle_lbl.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phasor Count:";
            // 
            // phasorCount_lbl
            // 
            this.phasorCount_lbl.AutoSize = true;
            this.phasorCount_lbl.Location = new System.Drawing.Point(85, 59);
            this.phasorCount_lbl.Name = "phasorCount_lbl";
            this.phasorCount_lbl.Size = new System.Drawing.Size(35, 13);
            this.phasorCount_lbl.TabIndex = 4;
            this.phasorCount_lbl.Text = "label1";
            // 
            // addPhasor_btn
            // 
            this.addPhasor_btn.Location = new System.Drawing.Point(271, 12);
            this.addPhasor_btn.Name = "addPhasor_btn";
            this.addPhasor_btn.Size = new System.Drawing.Size(71, 23);
            this.addPhasor_btn.TabIndex = 6;
            this.addPhasor_btn.Text = "Add";
            this.addPhasor_btn.UseVisualStyleBackColor = true;
            this.addPhasor_btn.Click += new System.EventHandler(this.addPhasor_btn_Click);
            // 
            // removePhasor_btn
            // 
            this.removePhasor_btn.Location = new System.Drawing.Point(271, 41);
            this.removePhasor_btn.Name = "removePhasor_btn";
            this.removePhasor_btn.Size = new System.Drawing.Size(71, 23);
            this.removePhasor_btn.TabIndex = 7;
            this.removePhasor_btn.Text = "Remove";
            this.removePhasor_btn.UseVisualStyleBackColor = true;
            this.removePhasor_btn.Click += new System.EventHandler(this.removePhasor_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phasors to add:";
            // 
            // phasorsToAdd_lbl
            // 
            this.phasorsToAdd_lbl.AutoSize = true;
            this.phasorsToAdd_lbl.Location = new System.Drawing.Point(349, 67);
            this.phasorsToAdd_lbl.Name = "phasorsToAdd_lbl";
            this.phasorsToAdd_lbl.Size = new System.Drawing.Size(35, 13);
            this.phasorsToAdd_lbl.TabIndex = 8;
            this.phasorsToAdd_lbl.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Location = new System.Drawing.Point(448, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Speed Increase:";
            // 
            // speedIncrease_lbl
            // 
            this.speedIncrease_lbl.AutoSize = true;
            this.speedIncrease_lbl.Location = new System.Drawing.Point(532, 67);
            this.speedIncrease_lbl.Name = "speedIncrease_lbl";
            this.speedIncrease_lbl.Size = new System.Drawing.Size(35, 13);
            this.speedIncrease_lbl.TabIndex = 16;
            this.speedIncrease_lbl.Text = "label1";
            // 
            // increaseSpeed_btn
            // 
            this.increaseSpeed_btn.Location = new System.Drawing.Point(451, 12);
            this.increaseSpeed_btn.Name = "increaseSpeed_btn";
            this.increaseSpeed_btn.Size = new System.Drawing.Size(71, 23);
            this.increaseSpeed_btn.TabIndex = 15;
            this.increaseSpeed_btn.Text = "Increase";
            this.increaseSpeed_btn.UseVisualStyleBackColor = true;
            this.increaseSpeed_btn.Click += new System.EventHandler(this.increaseSpeed_btn_Click);
            // 
            // decreaseSpeed_btn
            // 
            this.decreaseSpeed_btn.Location = new System.Drawing.Point(451, 41);
            this.decreaseSpeed_btn.Name = "decreaseSpeed_btn";
            this.decreaseSpeed_btn.Size = new System.Drawing.Size(71, 23);
            this.decreaseSpeed_btn.TabIndex = 14;
            this.decreaseSpeed_btn.Text = "Decrease";
            this.decreaseSpeed_btn.UseVisualStyleBackColor = true;
            this.decreaseSpeed_btn.Click += new System.EventHandler(this.decreaseSpeed_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Location = new System.Drawing.Point(622, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Graph Stretch:";
            // 
            // graphStretch_lbl
            // 
            this.graphStretch_lbl.AutoSize = true;
            this.graphStretch_lbl.Location = new System.Drawing.Point(696, 67);
            this.graphStretch_lbl.Name = "graphStretch_lbl";
            this.graphStretch_lbl.Size = new System.Drawing.Size(35, 13);
            this.graphStretch_lbl.TabIndex = 20;
            this.graphStretch_lbl.Text = "label1";
            // 
            // graphIncrease_btn
            // 
            this.graphIncrease_btn.Location = new System.Drawing.Point(625, 12);
            this.graphIncrease_btn.Name = "graphIncrease_btn";
            this.graphIncrease_btn.Size = new System.Drawing.Size(71, 23);
            this.graphIncrease_btn.TabIndex = 19;
            this.graphIncrease_btn.Text = "Increase";
            this.graphIncrease_btn.UseVisualStyleBackColor = true;
            this.graphIncrease_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // graphDecrease_btn
            // 
            this.graphDecrease_btn.Location = new System.Drawing.Point(625, 41);
            this.graphDecrease_btn.Name = "graphDecrease_btn";
            this.graphDecrease_btn.Size = new System.Drawing.Size(71, 23);
            this.graphDecrease_btn.TabIndex = 18;
            this.graphDecrease_btn.Text = "Decrease";
            this.graphDecrease_btn.UseVisualStyleBackColor = true;
            this.graphDecrease_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.graphStretch_lbl);
            this.Controls.Add(this.graphIncrease_btn);
            this.Controls.Add(this.graphDecrease_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.speedIncrease_lbl);
            this.Controls.Add(this.increaseSpeed_btn);
            this.Controls.Add(this.decreaseSpeed_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phasorsToAdd_lbl);
            this.Controls.Add(this.removePhasor_btn);
            this.Controls.Add(this.addPhasor_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phasorCount_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.angle_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count_lbl);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sine Waves";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label count_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label angle_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label phasorCount_lbl;
        private System.Windows.Forms.Button addPhasor_btn;
        private System.Windows.Forms.Button removePhasor_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label phasorsToAdd_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label speedIncrease_lbl;
        private System.Windows.Forms.Button increaseSpeed_btn;
        private System.Windows.Forms.Button decreaseSpeed_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label graphStretch_lbl;
        private System.Windows.Forms.Button graphIncrease_btn;
        private System.Windows.Forms.Button graphDecrease_btn;
    }
}

