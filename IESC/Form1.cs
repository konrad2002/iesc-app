using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ich hab ken plan wie github funktioniert

namespace IESC
{
    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();

            TimeCount = 0;
            Count = 0;
            Run = "inactiv";
            Run_sek = 0;
        }
        
        public int TimeCount { get; private set; }
        public string Run { get; private set; }
        public int Run_sek { get; private set; }
        public int Count2 { get; private set; }
        public int Count { get; private set; }
        public double T1 { get; private set; }
        public double T2 { get; private set; }
        public double T3 { get; private set; }
        public double T4 { get; private set; }
        public double T5 { get; private set; }
        public double T6 { get; private set; }
        public double T7 { get; private set; }
        public double T8 { get; private set; }
        public bool Running { get; private set; }
        public string Wk_c { get; private set; }
        public string Meters { get; private set; }
        public string Wk_l { get; private set; }
        public string Meters_c { get; private set; }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Run = "activ";
            Console.WriteLine("Run has been started!");
            Console.WriteLine("");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Running == true)
            {
                //Lauf ist wurde beendet
                if (Run == "stopped")
                {
                    Run = "inactiv";

                    Console.WriteLine("Run had been finished");
                    log.Items.Insert(0, "Lauf beendet");
                    logTime.Items.Insert(0, "--:--");
                    logTime2.Items.Insert(0, "---");

                    Console.WriteLine("==========================");
                    log.Items.Insert(0, "=====================");
                    logTime.Items.Insert(0, "==:==");
                    logTime2.Items.Insert(0, "===");

                    //Abfrage von streamdata.php
                    WebClient wc = new WebClient();
                    string livetiming = wc.DownloadString("http://erzgebirgsschwimmcup.de/Livetiming/streamdata.php");
                    Console.WriteLine(livetiming);

                    //streamdata auswerten
                    string[] words = livetiming.Split('?');
                    string lane = "0";
                    string lane_1_meters = "0";
                    string lane_2_meters = "0";
                    string lane_3_meters = "0";
                    string lane_4_meters = "0";
                    string lane_1_time = "0";
                    string lane_2_time = "0";
                    string lane_3_time = "0";
                    string lane_4_time = "0";
                    foreach (string word in words)
                    {
                        string[] words2 = word.Split('#');
                        foreach (string word2 in words2)
                        {
                            if (word2 == "1")
                            {
                                lane = "1";
                            }
                            if (word2 == "2")
                            {
                                lane = "2";
                            }
                            if (word2 == "3")
                            {
                                lane = "3";
                            }
                            if (word2 == "4")
                            {
                                lane = "4";
                            }
                            if (word2 == "50" || word2 == "100" || word2 == "200")
                            {
                                if (lane == "1")
                                {
                                    lane_1_meters = word2;
                                }
                                if (lane == "2")
                                {
                                    lane_2_meters = word2;
                                }
                                if (lane == "3")
                                {
                                    lane_3_meters = word2;
                                }
                                if (lane == "4")
                                {
                                    lane_4_meters = word2;
                                }
                            }

                            if (lane != "0" || word2 != "1" || word2 != "2" || word2 != "3" || word2 != "4" || word2 != "50" || word2 != "100" || word2 != "200")
                            {
                                if (lane == "1")
                                {
                                    lane_1_time = word2;
                                }
                                if (lane == "2")
                                {
                                    lane_2_time = word2;
                                }
                                if (lane == "3")
                                {
                                    lane_3_time = word2;
                                }
                                if (lane == "4")
                                {
                                    lane_4_time = word2;
                                }
                            }
                        }
                    }

                    Console.WriteLine("=====================");
                    Console.WriteLine("Run before:");
                    Console.WriteLine("=====================");
                    Console.WriteLine("Lane 1:");
                    Console.WriteLine("Meters: " + lane_1_meters);
                    Console.WriteLine("Time:   " + lane_1_time);
                    Console.WriteLine("=====================");
                    Console.WriteLine("Lane 2:");
                    Console.WriteLine("Meters: " + lane_2_meters);
                    Console.WriteLine("Time:   " + lane_2_time);
                    Console.WriteLine("=====================");
                    Console.WriteLine("Lane 3:");
                    Console.WriteLine("Meters: " + lane_3_meters);
                    Console.WriteLine("Time:   " + lane_3_time);
                    Console.WriteLine("=====================");
                    Console.WriteLine("Lane 4:");
                    Console.WriteLine("Meters: " + lane_4_meters);
                    Console.WriteLine("Time:   " + lane_4_time);
                    Console.WriteLine("=====================");

                    //streamdata auswerten
                    string[] words3 = livetiming.Split('#');
                    Wk_l = "0";
                    Meters = "0";
                    int forcount = 0;
                    foreach (string word3 in words3)
                    {
                        forcount++;
                        if (forcount == 1)
                        {
                            Wk_l = word3;
                        }
                        if (forcount == 2)
                        {
                            int forcount2 = 0;
                            string[] words4 = word3.Split('m');
                            foreach (string word4 in words4)
                            {
                                forcount2++;
                                if (forcount2 == 1)
                                {
                                    Meters = word4;
                                }
                            }
                        }
                    }

                    Console.WriteLine("");
                    Console.WriteLine("WK:      " + Wk_l);
                    Console.WriteLine("Strecke: " + Meters + "m");
                    Console.WriteLine("");
                    Console.WriteLine("=====================");

                    //Zeiten mit richtigen Metern in Array
                    string StrRuntimes = "";

                    if (lane_1_meters == Meters)
                    {
                        StrRuntimes = StrRuntimes + "#" + lane_1_time;
                        Console.WriteLine(StrRuntimes);
                    }

                    if (lane_2_meters == Meters)
                    {
                        StrRuntimes = StrRuntimes + "#" + lane_2_time;
                        Console.WriteLine(StrRuntimes);
                    }

                    if (lane_3_meters == Meters)
                    {
                        StrRuntimes = StrRuntimes + "#" + lane_3_time;
                        Console.WriteLine(StrRuntimes);
                    }

                    if (lane_4_meters == Meters)
                    {
                        StrRuntimes = StrRuntimes + "#" + lane_4_time;
                        Console.WriteLine(StrRuntimes);
                    }

                    string[] Runtimes = StrRuntimes.Split('#');

                    int TimeFast = 10000000;

                    foreach (string Time in Runtimes)
                    {
                        if (!String.IsNullOrEmpty(Time))
                        {
                            Console.WriteLine("Zeit:");
                            Console.WriteLine(Time);

                            //Sekunden berechnen
                            string Time_min_str = Time.Substring(0, 2);
                            string Time_sek_str = Time.Substring(3, 2);

                            int Time_min = Int32.Parse(Time_min_str);
                            int Time_sek = Int32.Parse(Time_sek_str);

                            if (Time_min == 1)
                            {
                                Time_sek = Time_sek + 60;
                            }

                            if (Time_min == 02)
                            {
                                Time_sek = Time_sek + 120;
                            }

                            if (Time_min == 03)
                            {
                                Time_sek = Time_sek + 180;
                            }

                            if (Time_sek <= TimeFast)
                            {
                                TimeFast = Time_sek;
                            }
                        }
                    }

                    Run_sek = TimeFast;
                }
                //während keinem Lauf
                if (Run == "inactiv")
                {
                    //Abfrage, ob Lauf wieder gestartet
                    WebClient wc2 = new WebClient();
                    string livetimingD = wc2.DownloadString("http://erzgebirgsschwimmcup.de/Livetiming/livetime2.php");
                    if (livetimingD.Contains("Bahn"))
                    {
                        Run = "started";
                    }
                }

                //wenn Lauf gestartet:
                if (Run == "started")
                {
                    Run = "activ";
                    //Abfrage welche Strecke geschwommen wird
                    WebClient wc3 = new WebClient();
                    string livetimingD = wc3.DownloadString("http://erzgebirgsschwimmcup.de/Livetiming/streamdata.php");
                    Console.WriteLine(livetimingD);
                    Console.WriteLine("Run has been started!");
                    Console.WriteLine("");

                    log.Items.Insert(0, "Lauf wurde gestartet");
                    logTime.Items.Insert(0, "00:00");
                    logTime2.Items.Insert(0, "0");

                    //Werte aktueller Lauf
                    string distance = Meters;

                    //Szenenwechsel berechnen

                    //für 50m Stecken
                    if (distance == "50")
                    {
                        T1 = Math.Round(Run_sek * 0.3);
                        T2 = Math.Round(Run_sek * 0.7);
                        Time1.Text = T1.ToString();
                        Time2.Text = T2.ToString();
                        Time3.Text = " ";
                        Time4.Text = " ";
                        Time5.Text = " ";
                        Time6.Text = " ";
                        Time7.Text = " ";
                        Time8.Text = " ";
                    }
                    if (distance == "100")
                    {
                        T1 = Math.Round(Run_sek * 0.15);
                        T2 = Math.Round(Run_sek * 0.35);
                        T3 = Math.Round(Run_sek * 0.65);
                        T4 = Math.Round(Run_sek * 0.85);
                        Time1.Text = T1.ToString();
                        Time2.Text = T2.ToString();
                        Time3.Text = T3.ToString();
                        Time4.Text = T4.ToString();
                        Time5.Text = " ";
                        Time6.Text = " ";
                        Time7.Text = " ";
                        Time8.Text = " ";
                    }
                    if (distance == "200")
                    {
                        T1 = Math.Round(Run_sek * 0.075);
                        T2 = Math.Round(Run_sek * 0.175);
                        T3 = Math.Round(Run_sek * 0.325);
                        T4 = Math.Round(Run_sek * 0.425);
                        T5 = Math.Round(Run_sek * 0.575);
                        T6 = Math.Round(Run_sek * 0.675);
                        T7 = Math.Round(Run_sek * 0.825);
                        T8 = Math.Round(Run_sek * 0.925);
                        Time1.Text = T1.ToString();
                        Time2.Text = T2.ToString();
                        Time3.Text = T3.ToString();
                        Time4.Text = T4.ToString();
                        Time5.Text = T5.ToString();
                        Time6.Text = T6.ToString();
                        Time7.Text = T7.ToString();
                        Time8.Text = T8.ToString();
                    }


                    Console.WriteLine(Run_sek);
                    log.Items.Insert(0, "Sekunden: " + Run_sek);
                    logTime.Items.Insert(0, "00:00");
                    logTime2.Items.Insert(0, "0");

                    progressBar.Maximum = Run_sek;

                    TimeCount = 0;
                    Count = 0;
                    Count2 = 0;
                    clock.Text = "00:00";

                    //Auslesen streamdata.php für WK
                    WebClient wc = new WebClient();
                    string livetiming = wc.DownloadString("http://erzgebirgsschwimmcup.de/Livetiming/streamdata.php");

                    //WK ermitteln
                    string[] words3 = livetiming.Split('#');
                    Wk_c = "0";
                    Meters = "0";
                    int forcount = 0;
                    foreach (string word3 in words3)
                    {
                        forcount++;
                        if (forcount == 1)
                        {
                            Wk_c = word3;
                        }

                        if (forcount == 2)
                        {
                            int forcount2 = 0;
                            string[] words4 = word3.Split('m');
                            foreach (string word4 in words4)
                            {
                                forcount2++;
                                if (forcount2 == 1)
                                {
                                    Meters_c = word4;
                                }
                            }
                        }
                    }
                    Console.WriteLine("WK:      " + Wk_c);
                    Console.WriteLine("WK (l):  " + Wk_l);

                    WkBox.Text = Wk_c;

                    DistanceBox.Text = Meters_c + "m";
                }

                //während des Laufes:
                if (Run == "activ")
                {
                    //timer hochzählen
                    TimeCount = TimeCount + 1;
                    Console.WriteLine(TimeCount);
                    Count = Count + 1;
                    string display;
                    string display2;
                    if (Count >= 60)
                    {
                        Count = 0;
                        Count2++;
                    }

                    if (Count < 10)
                    {
                        display = "0" + Count.ToString();
                    }
                    else
                    {
                        display = Count.ToString();
                    }

                    if (Count2 < 10)
                    {
                        display2 = "0" + Count2.ToString();
                    }
                    else
                    {
                        display2 = Count2.ToString();
                    }

                    string output = display2 + ":" + display;
                    clock.Text = output;
                    TimeBox.Text = "" + TimeCount;



                    //wenn stichzeiten gleich aktueller Zeit Kamera wechseln
                    if (Wk_c == Wk_l) {
                        if (TimeCount == T1)
                        {
                            Console.WriteLine("Change Scene to webcam 2");
                            log.Items.Insert(0, "Wechsle Szene zu Webcam 2");
                            logTime.Items.Insert(0, output);
                            logTime2.Items.Insert(0, TimeCount);

                            //OBS Anweisungen
                            SendKeys.Send("^M");

                            T1 = 0;
                        }
                        if (TimeCount == T2)
                        {
                            Console.WriteLine("Change Scene to webcam 1");
                            log.Items.Insert(0, "Wechsle Szene zu Webcam 1");
                            logTime.Items.Insert(0, output);
                            logTime2.Items.Insert(0, TimeCount);

                            //OBS Anweisungen
                            SendKeys.Send("^N");

                            T2 = 0;
                        }
                        if (TimeCount == T3)
                        {
                            Console.WriteLine("Change Scene to webcam 2");
                            log.Items.Insert(0, "Wechsle Szene zu Webcam 2");
                            logTime.Items.Insert(0, output);
                            logTime2.Items.Insert(0, TimeCount);

                            //OBS Anweisungen
                            SendKeys.Send("^M");

                            T3 = 0;
                        }
                        if (TimeCount == T4)
                        {
                            Console.WriteLine("Change Scene to webcam 1");
                            log.Items.Insert(0, "Wechsle Szene zu Webcam 1");
                            logTime.Items.Insert(0, output);
                            logTime2.Items.Insert(0, TimeCount);

                            //OBS Anweisungen
                            SendKeys.Send("^N");

                            T4 = 0;
                        }
                        if (TimeCount == T5)
                        {
                            Console.WriteLine("Change Scene to webcam 2");
                            log.Items.Insert(0, "Wechsle Szene zu Webcam 2");
                            logTime.Items.Insert(0, output);
                            logTime2.Items.Insert(0, TimeCount);

                            //OBS Anweisungen
                            SendKeys.Send("^M");

                            T5 = 0;
                        }
                        if (TimeCount == T6)
                        {
                            Console.WriteLine("Change Scene to webcam 1");
                            log.Items.Insert(0, "Wechsle Szene zu Webcam 1");
                            logTime.Items.Insert(0, output);
                            logTime2.Items.Insert(0, TimeCount);

                            //OBS Anweisungen
                            SendKeys.Send("^N");

                            T6 = 0;
                        }
                        if (TimeCount == T7)
                        {
                            Console.WriteLine("Change Scene to webcam 2");
                            log.Items.Insert(0, "Wechsle Szene zu Webcam 2");
                            logTime.Items.Insert(0, output);
                            logTime2.Items.Insert(0, TimeCount);

                            //OBS Anweisungen
                            SendKeys.Send("^M");

                            T7 = 0;
                        }
                        if (TimeCount == T8)
                        {
                            Console.WriteLine("Change Scene to webcam 1");
                            log.Items.Insert(0, "Wechsle Szene zu Webcam 1");
                            logTime.Items.Insert(0, output);
                            logTime2.Items.Insert(0, TimeCount);

                            //OBS Anweisungen
                            SendKeys.Send("^N");

                            T8 = 0;
                        }
                    }
                    //Lauffortschritt in Progressbar
                    if (TimeCount <= Run_sek)
                    {
                        progressBar.Value = TimeCount;
                    }

                    //Abfrage, ob Lauf beendet
                    WebClient wc2 = new WebClient();
                    string livetimingD = wc2.DownloadString("http://erzgebirgsschwimmcup.de/Livetiming/livetime2.php");
                    if (!livetimingD.Contains("Bahn"))
                    {
                        Run = "stopped";
                    }
                }
            } else
            {
                textBox1.Text = "angehalten";
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            Run = "stopped";
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TimeCount = 0;
            Run = "activ";
            Count = 0;
            Count2 = 0;
            clock.Text = "00:00";
            progressBar.Value = 0;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            log.Items.Clear();
            logTime.Items.Clear();
            logTime2.Items.Clear();
        }

        private void BtnLivetiming_Click(object sender, EventArgs e)
        {
            Form Run = new run();
            Run.Show();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            Running = true;
            textBox1.Text = "läuft";
        }

        private void BtnExecuteStop_Click(object sender, EventArgs e)
        {
            Running = false;
            textBox1.Text = "wird pausiert...";
        }

        private void BtnRequest_Click(object sender, EventArgs e)
        {
            Run = "stopped";
        }

        private void BtnSwitcher_Click(object sender, EventArgs e)
        {
            Form Switcher = new switcher();
            Switcher.Show();
        }
    }
}
