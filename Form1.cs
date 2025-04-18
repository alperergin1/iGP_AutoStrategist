﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

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

            using (StreamReader sr = new StreamReader("C:\\Users\\alper\\Desktop\\circuits.txt"))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    {
                        satirlarList.Add(satir);
                        Tracks.Items.Add(satir);
                    }
                }
            }

            lapTime = 90.123;

            double ssLapT;
            double sLapT;
            double mLapT;
            double hLapT;
            double iLapT;
            double wLapT;
            double totalTime;

            int ssWearR;
            int sWearR;
            int mWearR;
            int hWearR;
            int iWearR;
            int wWearR;

            double pitLaneTime;
            if (!double.TryParse(pitLaneTL.Text, out pitLaneTime))
            {
                Console.WriteLine("Could not be converted!");
            }

            if (!double.TryParse(ssLapTB.Text, out ssLapT))
            {
                Console.WriteLine("Could not be converted!");
            }
            if (!double.TryParse(sLapTB.Text, out sLapT))
            {
                Console.WriteLine("Could not be converted!");
            }
            if (!double.TryParse(mLapTB.Text, out mLapT))
            {
                Console.WriteLine("Could not be converted!");
            }
            if (!double.TryParse(hLapTB.Text, out hLapT))
            {
                Console.WriteLine("Could not be converted!");
            }
            if (!double.TryParse(iLapTB.Text, out iLapT))
            {
                Console.WriteLine("Could not be converted!");
            }
            if (!double.TryParse(wLapTB.Text, out wLapT))
            {
                Console.WriteLine("Could not be converted!");
            }

            if (!int.TryParse(ssLapTB.Text, out ssWearR))
            {
                Console.WriteLine("Could not be converted!");
            }
            if (!int.TryParse(sLapTB.Text, out sWearR))
            {
                Console.WriteLine("Could not be converted!");
            }
            if (!int.TryParse(mLapTB.Text, out mWearR))
            {
                Console.WriteLine("Could not be converted!");
            }
            if (!int.TryParse(hLapTB.Text, out hWearR))
            {
                Console.WriteLine("Could not be converted!");
            }
            if (!int.TryParse(iLapTB.Text, out iWearR))
            {
                Console.WriteLine("Could not be converted!");
            }
            if (!int.TryParse(wLapTB.Text, out wWearR))
            {
                Console.WriteLine("Could not be converted!");
            }

            double[] lapTimes = { ssLapT, sLapT, mLapT, hLapT, iLapT, wLapT };
            double[] wearRates = { ssWearR, sWearR, mWearR, hWearR, iWearR, wWearR };

            DoPitStop(pitLaneTime, raceLength, lapTimes);

            int selectedTyreIndex = SelectTyre(lapTimes, wearRates);

            // other codes
        }

        private (int, bool) CalculateLapCount(double[] lapTimes, double raceLength)
        {
            int lapCount = (int)Math.Floor(raceLength / lapTimes[0]);
            bool pitRequired = lapTimes.Sum() * raceLength <= 50.0; 
            return (lapCount, pitRequired);
        }

        public void DoPitStop(double pitLaneTime, double raceLength, double[] lapTimes)
        {
            int lapCount = lapTimes.Length;
            double totalTime = 0;

            MessageBox.Show("Total Race Time: " + totalTime);

            totalTime += pitLaneTime;

            for (int i = 0; i < lapCount; i++)
            {
                if (lapTimes[i] > pitLaneTime)
                {
                    totalTime += lapTimes[i];
                }
                else
                {
                    totalTime += pitLaneTime;
                }
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalculateStrategy();
            // Other codes if needed
        }

        private struct BestTyres
        {
            public int BestTyreIndex;
            public int SecondBestTyreIndex;
            public int ThirdBestTyreIndex;
        }
        private BestTyres SelectBestTyres(double[] lapTimes, double[] wearRates)
        {
            BestTyres bestTyres = new BestTyres();
            bestTyres.BestTyreIndex = 0; 
            bestTyres.SecondBestTyreIndex = 1; 
            bestTyres.ThirdBestTyreIndex = 2; 

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


        private void CalculateStrategy()
        {
            double fuelUsePerLap;
            if (!double.TryParse(fuelUsePLTB.Text, out fuelUsePerLap))
            {
                MessageBox.Show("Please enter a valid number for fuel use per lap.");
                return;
            }

            double totalLaps;
            if (!double.TryParse(totalLTB.Text, out totalLaps))
            {
                MessageBox.Show("Please enter a valid number for total laps.");
                return;
            }

            // adding L4 just incase
            const double extraFuel = 4.0;

            // Calcualtings
            double totalFuelUse = fuelUsePerLap * totalLaps + extraFuel;
            string totalFuelUseStr = totalFuelUse.ToString();
            labelFuelNeeded.Text = totalFuelUseStr;
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
            //add other if needed
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTracksFromFile("C:\\Users\\alper\\Desktop\\circuits.txt");
        }
        private void LoadTracksFromFile(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    satirlarList.Add(satir);
                    Tracks.Items.Add(satir); // add control name
                }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            // Similar to original implementation
        }

        private void totalLTB_TextChanged(object sender, EventArgs e)
        {
            // Similar to original implementation
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.Clear();
                }
            }
        }
    }
}
