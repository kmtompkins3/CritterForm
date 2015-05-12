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

namespace critter
{
    public partial class Form1 : Form
    {
        int Health = 100;

        int Hunger = 95;
        int HungerIncrease = 5;
        int Happieness = 95;
        int HappienessIncrease = 5;
        int Waste = 0;

        //threads
        Thread HealthIncrease;
        Thread HungerDecrease;
        Thread HappienessDecrease;
        Thread WasteIncrease;
        //Thread Illness;

        public Form1()
        {
            InitializeComponent();
            HealthBar.Minimum = 0;
            HealthBar.Maximum = 100;
            HealthBar.Value = Health;
            HungerBar.Minimum = 0;
            HungerBar.Maximum = 150;
            HungerBar.Value = Hunger;
            HappienessBar.Minimum = 0;
            HappienessBar.Maximum = 100;
            HappienessBar.Value = Happieness;
            WasteBar.Minimum = 0;
            WasteBar.Maximum = 100;
            WasteBar.Value = Waste;

            HealthIncrease = new Thread(new ThreadStart(HealthIncreaseThread));//creates function for thread
            HealthIncrease.Start();//starts thread
            HungerDecrease = new Thread(new ThreadStart(HungerDecreaseThread));//creates function for thread
            HungerDecrease.Start();//starts thread
            HappienessDecrease = new Thread(new ThreadStart(HappienessDecreaseThread));//creates function for thread
            HappienessDecrease.Start();//starts thread
            WasteIncrease = new Thread(new ThreadStart(WasteIncreaseThread));//creates function for thread
            WasteIncrease.Start();//starts thread

        }

        #region FeedButton
        //feed button
        private void button1_Click(object sender, EventArgs e)
        {
            Hunger = Hunger + HungerIncrease;
            HungerBar.Value = Hunger;
            if (Hunger <= 100 && Happieness <= 95)
            {
                HungerIncrease = 5;
                Happieness = Happieness + 5;
                HappienessBar.Value = Happieness;
                Waste = Waste + 5;
                WasteBar.Value = Waste;

                if (Health <= 95)
                {
                    Health = Health + 5;
                    HealthBar.Value = Health;
                }
            }
            if (Hunger >= 110 && Waste < 90)
            {
                Happieness = Happieness - 5;
                HappienessBar.Value = Happieness;
                Waste = Waste + 10;
                WasteBar.Value = Waste;
            }
            //here
            if (Hunger >= 100)
            {
                WarningBox.Text = "You are going to over feed your critter";
            }
            if (Hunger >= 150)
            {
                WarningBox.Text = "You have over fed your critter there will be consequences";
                HungerIncrease = 0;
                if (Health >= 5)
                {
                    Health = Health - 5;
                    HealthBar.Value = Health;
                }
                if (Health <= 0)
                {
                    WarningBox.Text = "Your critter is dead";
                }
            }
        }
        #endregion

        #region PlayButton
        private void Play_Click(object sender, EventArgs e)
        {
            Happieness = Happieness + HappienessIncrease;
            if (Happieness >= 95 && Health != 0)
            {
                WarningBox.Text = "Your going to over work your critter";
                if (Hunger >= 10)
                {
                    Hunger = Hunger - 10;
                    HungerBar.Value = Hunger;
                }
                if (Health >= 5)
                {
                    Health = Health - 5;
                    HealthBar.Value = Health;
                    if (Health <= 0)
                    {
                        WarningBox.Text = "Your critter is dead";
                    }
                }
                if (Happieness > 5)
                {
                    Happieness = Happieness - 40;
                    HappienessBar.Value = Happieness;
                }
            }
            if (Happieness < 95)
            {
                Happieness = Happieness + 5;
                HappienessBar.Value = Happieness;
            }
            if (Happieness == 0)
            {
                Health = Health - 10;
                HealthBar.Value = Health;
            }
        }
        #endregion

        #region CleanButton

        private void Clean_Click(object sender, EventArgs e)
        {
            if (Waste >= 5)
            {
                Waste = Waste - 5;
                WasteBar.Value = Waste;
                if (Happieness <= 95)
                {
                    Happieness = Happieness + 5;
                    HappienessBar.Value = Happieness;
                }
            }
        }

        #endregion

        #region ResetButton
        private void Reset_Click(object sender, EventArgs e)
        {
            Health = 100;
            Hunger = 95;
            HungerIncrease = 5;
            Happieness = 95;
            HappienessIncrease = 5;
            Waste = 0;
            HealthBar.Minimum = 0;
            HealthBar.Maximum = 100;
            HealthBar.Value = Health;
            HungerBar.Minimum = 0;
            HungerBar.Maximum = 150;
            HungerBar.Value = Hunger;
            HappienessBar.Minimum = 0;
            HappienessBar.Maximum = 100;
            HappienessBar.Value = Happieness;
            WasteBar.Minimum = 0;
            WasteBar.Maximum = 100;
            WasteBar.Value = Waste;

            WarningBox.Text = "Critter Reset";
        }

        #endregion

        private void HealthIncreaseThread()
        {
            try
            {
                while (true)
                {
                    Random rnd = new Random();
                    int RandomHealth = rnd.Next(1, 6);

                    if (Health <= 95 && Health != 0)
                    {
                        switch (RandomHealth)
                        {
                            case 1:
                                Health = Health + 0;
                                HealthBar.Invoke((MethodInvoker)(() => HealthBar.Value = Health));
                                break;
                            case 2:
                                Health = Health + 1;
                                HealthBar.Invoke((MethodInvoker)(() => HealthBar.Value = Health));
                                break;
                            case 3:
                                Health = Health + 2;
                                HealthBar.Invoke((MethodInvoker)(() => HealthBar.Value = Health));
                                break;
                            case 4:
                                Health = Health + 3;
                                HealthBar.Invoke((MethodInvoker)(() => HealthBar.Value = Health));
                                break;
                            case 5:
                                Health = Health + 4;
                                HealthBar.Invoke((MethodInvoker)(() => HealthBar.Value = Health));
                                break;
                            case 6:
                                Health = Health + 5;
                                HealthBar.Invoke((MethodInvoker)(() => HealthBar.Value = Health));
                                break;
                        }
                    }
                    Thread.Sleep(5000);
                }

            }
            catch (ThreadAbortException tbe)
            {
                HealthIncrease.Abort();//ends thread
            }
        }

        private void WasteIncreaseThread()
        {
            try
            {
                while (true)
                {
                    Random rnd = new Random();
                    int RandomWaste= rnd.Next(1, 6);

                    if (Waste <= 95)
                    {
                        switch (RandomWaste)
                        {
                            case 1:
                                Waste = Waste + 0;
                                WasteBar.Invoke((MethodInvoker)(() => WasteBar.Value = Waste));
                                break;
                            case 2:
                                Waste = Waste + 1;
                                WasteBar.Invoke((MethodInvoker)(() => WasteBar.Value = Waste));
                                break;
                            case 3:
                                Waste = Waste + 2;
                                WasteBar.Invoke((MethodInvoker)(() => WasteBar.Value = Waste));
                                break;
                            case 4:
                                Waste = Waste + 3;
                                WasteBar.Invoke((MethodInvoker)(() => WasteBar.Value = Waste));
                                break;
                            case 5:
                                Waste = Waste + 4;
                                WasteBar.Invoke((MethodInvoker)(() => WasteBar.Value = Waste));
                                break;
                            case 6:
                                Waste = Waste + 5;
                                WasteBar.Invoke((MethodInvoker)(() => WasteBar.Value = Waste));
                                break;
                        }
                    }
                    Thread.Sleep(8000);
                }

            }
            catch (ThreadAbortException tbe)
            {
                WasteIncrease.Abort();//ends thread
            }
        }

        private void HappienessDecreaseThread()
        {
            try
            {
                while (true)
                {
                    Random rnd = new Random();
                    int RandomHappieness = rnd.Next(1, 6);

                    if (Happieness < 100 && Happieness >=5 )
                    {
                        switch (RandomHappieness)
                        {
                            case 1:
                                Happieness = Happieness - 0;
                                HappienessBar.Invoke((MethodInvoker)(() => HappienessBar.Value = Happieness));
                                break;
                            case 2:
                                Happieness = Happieness - 1;
                                HappienessBar.Invoke((MethodInvoker)(() => HappienessBar.Value = Happieness));
                                break;
                            case 3:
                                Happieness = Happieness - 2;
                                HappienessBar.Invoke((MethodInvoker)(() => HappienessBar.Value = Happieness));
                                break;
                            case 4:
                                Happieness = Happieness - 3;
                                HappienessBar.Invoke((MethodInvoker)(() => HappienessBar.Value = Happieness));
                                break;
                            case 5:
                                Happieness = Happieness - 4;
                                HappienessBar.Invoke((MethodInvoker)(() => HappienessBar.Value = Happieness));
                                break;
                            case 6:
                                Happieness = Happieness - 5;
                                HappienessBar.Invoke((MethodInvoker)(() => HappienessBar.Value = Happieness));
                                break;
                        }
                    }
                    Thread.Sleep(3000);
                }

            }
            catch (ThreadAbortException tbe)
            {
                HappienessDecrease.Abort();//ends thread
            }
        }

        private void HungerDecreaseThread()
        {
            try
            {
                while (true)
                {
                    Random rnd = new Random();
                    int RandomHappieness = rnd.Next(1, 6);

                    if (Happieness < 100 && Happieness >= 5)
                    {
                        switch (RandomHappieness)
                        {
                            case 1:
                                Happieness = Happieness - 0;
                                HappienessBar.Invoke((MethodInvoker)(() => HappienessBar.Value = Happieness));
                                break;
                            case 2:
                                Happieness = Happieness - 1;
                                HappienessBar.Invoke((MethodInvoker)(() => HappienessBar.Value = Happieness));
                                break;
                            case 3:
                                Happieness = Happieness - 2;
                                HappienessBar.Invoke((MethodInvoker)(() => HappienessBar.Value = Happieness));
                                break;
                            case 4:
                                Happieness = Happieness - 3;
                                HappienessBar.Invoke((MethodInvoker)(() => HappienessBar.Value = Happieness));
                                break;
                            case 5:
                                Happieness = Happieness - 4;
                                HappienessBar.Invoke((MethodInvoker)(() => HappienessBar.Value = Happieness));
                                break;
                            case 6:
                                Happieness = Happieness - 5;
                                HappienessBar.Invoke((MethodInvoker)(() => HappienessBar.Value = Happieness));
                                break;
                        }
                    }
                    Thread.Sleep(3000);
                }

            }
            catch (ThreadAbortException tbe)
            {
                HappienessDecrease.Abort();//ends thread
            }
        }

    }
}
