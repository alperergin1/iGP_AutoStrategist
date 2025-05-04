using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace iGP_AutoStrategist
{
    public partial class Form1 : Form
    {
        private double raceLength;
        private List<Tire> tires = new List<Tire>();
        List<string> satirlarList = new List<string>();

        private double lapTime;
        double pitLaneTime;

        public Form1()
        {
            InitializeComponent();
            LoadTracksFromFile();

            lapTime = 90.123;
            pitLaneTime = 0.0; // Default pit lane time, will be updated later

            InitializeLapTimes();
        }

        // Helper method to parse doubles and show error if invalid
        private bool TryParseDouble(string input, out double result, string fieldName)
        {
            if (!double.TryParse(input, out result))
            {
                MessageBox.Show($"{fieldName} must be a valid number.");
                return false;
            }
            return true;
        }

        // Initialize lap times from input fields
        private void InitializeLapTimes()
        {
            double ssLapT, sLapT, mLapT, hLapT, iLapT, wLapT;

            if (!TryParseDouble(ssLapTB.Text, out ssLapT, "SS Lap Time") ||
                !TryParseDouble(sLapTB.Text, out sLapT, "S Lap Time") ||
                !TryParseDouble(mLapTB.Text, out mLapT, "M Lap Time") ||
                !TryParseDouble(hLapTB.Text, out hLapT, "H Lap Time") ||
                !TryParseDouble(iLapTB.Text, out iLapT, "I Lap Time") ||
                !TryParseDouble(wLapTB.Text, out wLapT, "W Lap Time"))
            {
                return;
            }

           
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTracksFromFile();
        }

        // Tire class
        private class Tire
        {
            public string Type { get; set; }
            public double LapTime { get; set; }
            public double WearRate { get; set; }

            public Tire(string type, double lapTime, double wearRate)
            {
                Type = type;
                LapTime = lapTime;
                WearRate = wearRate;
            }
        }
    }
}
