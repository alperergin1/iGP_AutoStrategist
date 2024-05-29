namespace iGP_AutoStrategist
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
            this.refueling = new System.Windows.Forms.CheckBox();
            this.fuelUsePLTB = new System.Windows.Forms.TextBox();
            this.totalLTB = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.Tracks = new System.Windows.Forms.ListBox();
            this.ssLapTB = new System.Windows.Forms.TextBox();
            this.sLapTB = new System.Windows.Forms.TextBox();
            this.mLapTB = new System.Windows.Forms.TextBox();
            this.hLapTB = new System.Windows.Forms.TextBox();
            this.ssWearRateTB = new System.Windows.Forms.TextBox();
            this.sWearRateTB = new System.Windows.Forms.TextBox();
            this.mWearRateTB = new System.Windows.Forms.TextBox();
            this.hWearRateTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iLapTB = new System.Windows.Forms.TextBox();
            this.wLapTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.wWearRateTB = new System.Windows.Forms.TextBox();
            this.iWearRateTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelFuelNeeded = new System.Windows.Forms.Label();
            this.labelPitRequired = new System.Windows.Forms.Label();
            this.pitLaneTL = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // refueling
            // 
            this.refueling.AutoSize = true;
            this.refueling.Location = new System.Drawing.Point(786, 544);
            this.refueling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refueling.Name = "refueling";
            this.refueling.Size = new System.Drawing.Size(76, 29);
            this.refueling.TabIndex = 0;
            this.refueling.Text = "reF";
            this.refueling.UseVisualStyleBackColor = true;
            // 
            // fuelUsePLTB
            // 
            this.fuelUsePLTB.Location = new System.Drawing.Point(120, 367);
            this.fuelUsePLTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fuelUsePLTB.Name = "fuelUsePLTB";
            this.fuelUsePLTB.Size = new System.Drawing.Size(132, 31);
            this.fuelUsePLTB.TabIndex = 1;
            // 
            // totalLTB
            // 
            this.totalLTB.Location = new System.Drawing.Point(120, 404);
            this.totalLTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalLTB.Name = "totalLTB";
            this.totalLTB.Size = new System.Drawing.Size(84, 31);
            this.totalLTB.TabIndex = 2;
            this.totalLTB.TextChanged += new System.EventHandler(this.totalLTB_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(264, 558);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(154, 85);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(468, 558);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(154, 85);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // Tracks
            // 
            this.Tracks.FormattingEnabled = true;
            this.Tracks.ItemHeight = 25;
            this.Tracks.Location = new System.Drawing.Point(528, 46);
            this.Tracks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tracks.Name = "Tracks";
            this.Tracks.Size = new System.Drawing.Size(396, 204);
            this.Tracks.TabIndex = 5;
            // 
            // ssLapTB
            // 
            this.ssLapTB.Location = new System.Drawing.Point(92, 87);
            this.ssLapTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ssLapTB.Name = "ssLapTB";
            this.ssLapTB.Size = new System.Drawing.Size(160, 31);
            this.ssLapTB.TabIndex = 6;
            // 
            // sLapTB
            // 
            this.sLapTB.Location = new System.Drawing.Point(92, 123);
            this.sLapTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sLapTB.Name = "sLapTB";
            this.sLapTB.Size = new System.Drawing.Size(160, 31);
            this.sLapTB.TabIndex = 7;
            // 
            // mLapTB
            // 
            this.mLapTB.Location = new System.Drawing.Point(92, 163);
            this.mLapTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mLapTB.Name = "mLapTB";
            this.mLapTB.Size = new System.Drawing.Size(160, 31);
            this.mLapTB.TabIndex = 8;
            // 
            // hLapTB
            // 
            this.hLapTB.Location = new System.Drawing.Point(92, 202);
            this.hLapTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hLapTB.Name = "hLapTB";
            this.hLapTB.Size = new System.Drawing.Size(160, 31);
            this.hLapTB.TabIndex = 9;
            // 
            // ssWearRateTB
            // 
            this.ssWearRateTB.Location = new System.Drawing.Point(400, 87);
            this.ssWearRateTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ssWearRateTB.Name = "ssWearRateTB";
            this.ssWearRateTB.Size = new System.Drawing.Size(88, 31);
            this.ssWearRateTB.TabIndex = 10;
            // 
            // sWearRateTB
            // 
            this.sWearRateTB.Location = new System.Drawing.Point(400, 123);
            this.sWearRateTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sWearRateTB.Name = "sWearRateTB";
            this.sWearRateTB.Size = new System.Drawing.Size(88, 31);
            this.sWearRateTB.TabIndex = 11;
            // 
            // mWearRateTB
            // 
            this.mWearRateTB.Location = new System.Drawing.Point(400, 163);
            this.mWearRateTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mWearRateTB.Name = "mWearRateTB";
            this.mWearRateTB.Size = new System.Drawing.Size(88, 31);
            this.mWearRateTB.TabIndex = 12;
            // 
            // hWearRateTB
            // 
            this.hWearRateTB.Location = new System.Drawing.Point(400, 202);
            this.hWearRateTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hWearRateTB.Name = "hWearRateTB";
            this.hWearRateTB.Size = new System.Drawing.Size(88, 31);
            this.hWearRateTB.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "ssLap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "sLap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "mLap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "hLap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "ssWear";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "sWear";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "mWear";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "hWear";
            // 
            // iLapTB
            // 
            this.iLapTB.Location = new System.Drawing.Point(92, 254);
            this.iLapTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iLapTB.Name = "iLapTB";
            this.iLapTB.Size = new System.Drawing.Size(160, 31);
            this.iLapTB.TabIndex = 22;
            // 
            // wLapTB
            // 
            this.wLapTB.Location = new System.Drawing.Point(92, 292);
            this.wLapTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wLapTB.Name = "wLapTB";
            this.wLapTB.Size = new System.Drawing.Size(160, 31);
            this.wLapTB.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 260);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "iLap";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 292);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "wLap";
            // 
            // wWearRateTB
            // 
            this.wWearRateTB.Location = new System.Drawing.Point(400, 292);
            this.wWearRateTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wWearRateTB.Name = "wWearRateTB";
            this.wWearRateTB.Size = new System.Drawing.Size(88, 31);
            this.wWearRateTB.TabIndex = 27;
            // 
            // iWearRateTB
            // 
            this.iWearRateTB.Location = new System.Drawing.Point(400, 254);
            this.iWearRateTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iWearRateTB.Name = "iWearRateTB";
            this.iWearRateTB.Size = new System.Drawing.Size(88, 31);
            this.iWearRateTB.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 296);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "wWear";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(290, 254);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "iWear";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(86, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "LapTimes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(396, 46);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "ssLap";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 371);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 25);
            this.label15.TabIndex = 32;
            this.label15.Text = "FuelUse";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 408);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 25);
            this.label16.TabIndex = 33;
            this.label16.Text = "Laps";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // labelFuelNeeded
            // 
            this.labelFuelNeeded.AutoSize = true;
            this.labelFuelNeeded.Location = new System.Drawing.Point(568, 462);
            this.labelFuelNeeded.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFuelNeeded.Name = "labelFuelNeeded";
            this.labelFuelNeeded.Size = new System.Drawing.Size(82, 25);
            this.labelFuelNeeded.TabIndex = 34;
            this.labelFuelNeeded.Text = "label17";
            // 
            // labelPitRequired
            // 
            this.labelPitRequired.AutoSize = true;
            this.labelPitRequired.Location = new System.Drawing.Point(568, 504);
            this.labelPitRequired.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPitRequired.Name = "labelPitRequired";
            this.labelPitRequired.Size = new System.Drawing.Size(82, 25);
            this.labelPitRequired.TabIndex = 35;
            this.labelPitRequired.Text = "label18";
            // 
            // pitLaneTL
            // 
            this.pitLaneTL.Location = new System.Drawing.Point(120, 448);
            this.pitLaneTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pitLaneTL.Name = "pitLaneTL";
            this.pitLaneTL.Size = new System.Drawing.Size(84, 31);
            this.pitLaneTL.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 462);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 25);
            this.label17.TabIndex = 37;
            this.label17.Text = "PitTime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 781);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pitLaneTL);
            this.Controls.Add(this.labelPitRequired);
            this.Controls.Add(this.labelFuelNeeded);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.wWearRateTB);
            this.Controls.Add(this.iWearRateTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.wLapTB);
            this.Controls.Add(this.iLapTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hWearRateTB);
            this.Controls.Add(this.mWearRateTB);
            this.Controls.Add(this.sWearRateTB);
            this.Controls.Add(this.ssWearRateTB);
            this.Controls.Add(this.hLapTB);
            this.Controls.Add(this.mLapTB);
            this.Controls.Add(this.sLapTB);
            this.Controls.Add(this.ssLapTB);
            this.Controls.Add(this.Tracks);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalLTB);
            this.Controls.Add(this.fuelUsePLTB);
            this.Controls.Add(this.refueling);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox refueling;
        private System.Windows.Forms.TextBox fuelUsePLTB;
        private System.Windows.Forms.TextBox totalLTB;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ListBox Tracks;
        private System.Windows.Forms.TextBox ssLapTB;
        private System.Windows.Forms.TextBox sLapTB;
        private System.Windows.Forms.TextBox mLapTB;
        private System.Windows.Forms.TextBox hLapTB;
        private System.Windows.Forms.TextBox ssWearRateTB;
        private System.Windows.Forms.TextBox sWearRateTB;
        private System.Windows.Forms.TextBox mWearRateTB;
        private System.Windows.Forms.TextBox hWearRateTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox iLapTB;
        private System.Windows.Forms.TextBox wLapTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox wWearRateTB;
        private System.Windows.Forms.TextBox iWearRateTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelFuelNeeded;
        private System.Windows.Forms.Label labelPitRequired;
        private System.Windows.Forms.TextBox pitLaneTL;
        private System.Windows.Forms.Label label17;
    }
}

