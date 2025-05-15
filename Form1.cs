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

            // Initialize wear rates from input fields
            int ssWearR, sWearR, mWearR, hWearR, iWearR, wWearR;

            if (!int.TryParse(ssLapTB.Text, out ssWearR) ||
                !int.TryParse(sLapTB.Text, out sWearR) ||
                !int.TryParse(mLapTB.Text, out mWearR) ||
                !int.TryParse(hLapTB.Text, out hWearR) ||
                !int.TryParse(iLapTB.Text, out iWearR) ||
                !int.TryParse(wLapTB.Text, out wWearR))
            {
                MessageBox.Show("Wear rates must be valid integers.");
                return;
            }

            double[] lapTimes = { ssLapT, sLapT, mLapT, hLapT, iLapT, wLapT };
            double[] wearRates = { ssWearR, sWearR, mWearR, hWearR, iWearR, wWearR };

            DoPitStop(pitLaneTime, raceLength, lapTimes);

            int selectedTyreIndex = SelectTyre(lapTimes, wearRates);
            // other codes
        }

        // Helper method to load tracks from a file
        private void LoadTracksFromFile()
        {
            string filePath = Path.Combine(Application.StartupPath, "circuits.txt");

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        satirlarList.Add(line);
                        Tracks.Items.Add(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("Circuit file not found!");
            }
        }

        // Calculate lap count and if a pit stop is required
        private (int, bool) CalculateLapCount(double[] lapTimes, double raceLength)
        {
            int lapCount = (int)Math.Floor(raceLength / lapTimes[0]);
            bool pitRequired = lapTimes.Sum() * raceLength <= 50.0;
            return (lapCount, pitRequired);
        }

        // Method to perform a pit stop and calculate total race time
        public void DoPitStop(double pitLaneTime, double raceLength, double[] lapTimes)
        {
            int lapCount = lapTimes.Length;
            double totalTime = pitLaneTime + lapTimes.Sum();

            MessageBox.Show("Total Race Time: " + totalTime);
        }

        // Select the best tyres based on lap times and wear rates
        private struct BestTyres
        {
            public int BestTyreIndex;
            public int SecondBestTyreIndex;
            public int ThirdBestTyreIndex;
        }

        private BestTyres SelectBestTyres(double[] lapTimes, double[] wearRates)
        {
            BestTyres bestTyres = new BestTyres
            {
                BestTyreIndex = 0,
                SecondBestTyreIndex = 1,
                ThirdBestTyreIndex = 2
            };

            for (int i = 1; i < lapTimes.Length; i++)
            {
                if (lapTimes[i] < lapTimes[bestTyres.BestTyreIndex])
                {
                    bestTyres.ThirdBestTyreIndex = bestTyres.SecondBestTyreIndex;
                    bestTyres.SecondBestTyreIndex = bestTyres.BestTyreIndex;
                    bestTyres.BestTyreIndex = i;
                }
                else if (lapTimes[i] < lapTimes[bestTyres.SecondBestTyreIndex])
                {
                    bestTyres.ThirdBestTyreIndex = bestTyres.SecondBestTyreIndex;
                    bestTyres.SecondBestTyreIndex = i;
                }
                else if (lapTimes[i] < lapTimes[bestTyres.ThirdBestTyreIndex])
                {
                    bestTyres.ThirdBestTyreIndex = i;
                }
            }

            return bestTyres;
        }

        // Select the best tyre based on lap time and wear rate
        private int SelectTyre(double[] lapTimes, double[] wearRates)
        {
            double minLapTime = lapTimes[0];
            double minWearRate = wearRates[0];
            int selectedTyreIndex = 0;

            for (int i = 1; i < lapTimes.Length; i++)
            {
                if (lapTimes[i] < minLapTime || (lapTimes[i] == minLapTime && wearRates[i] < minWearRate))
                {
                    minLapTime = lapTimes[i];
                    minWearRate = wearRates[i];
                    selectedTyreIndex = i;
                }
            }

            return selectedTyreIndex;
        }

        // Calculate race strategy including fuel use
        private void CalculateStrategy()
        {
            double fuelUsePerLap;
            double totalLaps;

            if (!TryGetFuelData(out fuelUsePerLap, out totalLaps))
            {
                return;
            }

            const double extraFuel = 4.0;
            double totalFuelUse = fuelUsePerLap * totalLaps + extraFuel;

            labelFuelNeeded.Text = totalFuelUse.ToString();
        }

        // Helper method
        private bool TryGetFuelData(out double fuelUsePerLap, out double totalLaps)
        {
            if (!TryParseDouble(fuelUsePLTB.Text, out fuelUsePerLap, "Fuel Use Per Lap") ||
                !TryParseDouble(totalLTB.Text, out totalLaps, "Total Laps"))
            {
                fuelUsePerLap = 0;
                totalLaps = 0;
                return false;
            }

            return true;
        }

        // Clear all input fields
        private void clearButton_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        // Event handlers for buttons and other UI components
        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalculateStrategy();
        }

        // Event handlers
        private void label16_Click(object sender, EventArgs e)
        {
            // Add implementation here if needed
        }

        private void totalLTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTracksFromFile();
        }

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
