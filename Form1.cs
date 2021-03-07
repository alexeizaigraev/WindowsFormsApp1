using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //private System.Windows.Forms.CheckedListBox checkedListBox1;
        public Form1()
        {
            InitializeComponent();
            // Sets up the initial objects in the CheckedListBox.
            //string[] myFruit = { "Apples", "Oranges", "Tomato" };
            //checkedListBox1.Items.AddRange(myFruit);

            // Changes the selection mode from double-click to single click.
            //checkedListBox1.CheckOnClick = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox2.Text = "";
            textBox3.Text = "";
            string partner = (string)checkedListBox1.SelectedItem;
            Papa.partnerCoised = partner;
            textBox1.Text = partner;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            int x = 0;
            try 
            {
                x = HrDeps.MainHrDeps();
                textBox2.Text = Papa.infoSmall;
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
            int x = 0;
            try
            {
                x = Priem.MainPriem();
                textBox2.Text = Papa.infoSmall;
            }
            catch { textBox2.Text = "Error"; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = Otpusk.MainOtpusk();
                textBox2.Text = Papa.infoSmall;
                textBox3.Text = Papa.infoBig;
            }
            catch { textBox2.Text = "Error"; }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = Perevod.MainPerevod();
                textBox2.Text = Papa.infoSmall;
                //textBox3.Text = Papa.infoBig;
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = PostAll.MainPostAll();
                textBox2.Text = "Success";
                textBox3.Text = Papa.infoBig + " \n" + Papa.infoSmall;
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = Monitor.MainMonitor();
                textBox2.Text = "Success";
                textBox3.Text = Papa.infoBig + " \n" + Papa.infoSmall;
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = Rasklad.MainRasklad();
                textBox2.Text = "Success";
                textBox3.Text = Papa.infoBig + " \n" + Papa.infoSmall;
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = AccessBackUp.MainAccessBackUp();
                textBox2.Text = "Success";
                textBox3.Text = Papa.infoBig + " \n" + Papa.infoSmall;
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = Term.MainTerm();
                textBox2.Text = Papa.infoSmall;
                textBox3.Text = Papa.infoBig;
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = SiteNew.MainSite();
                textBox2.Text = Papa.infoSmall;
                //textBox3.Text = Papa.infoBig;
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = Natasha.MainNatasha();
                textBox2.Text = Papa.infoSmall;
                //textBox3.Text = Papa.infoBig;
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                //x = Otmena();
                Papa.infoSmall = "";
                Papa.infoBig = "";
                textBox1.Text = "";
                textBox2.Text = " Qu-Qu :)";
                textBox3.Text = "Bom!  Bom! Bom!";
                textBox4.Text = "";
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox2.Text = "wait...";
            textBox1.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = Knigi.MainKnigi();
                textBox1.Text = "";
                textBox2.Text = Papa.infoSmall;
                textBox3.Text = Papa.infoBig;
            }
            catch { textBox2.Text = "Error"; }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox2.Text = "wait...";
            textBox1.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = Rro.MainRro();
                textBox1.Text = "";
                textBox2.Text = Papa.infoSmall;
                textBox3.Text = Papa.infoBig;
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox2.Text = "wait...";
            textBox1.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = Pereezd.MainPereezd();
                textBox2.Text = Papa.infoSmall;
                textBox3.Text = Papa.infoBig;
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox2.Text = "wait...";
            textBox1.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = Otmena.MainOtmena();
                textBox2.Text = Papa.infoSmall;
                textBox3.Text = Papa.infoBig;
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Otbor.otborChoise = textBox4.Text;
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox2.Text = "wait...";
            textBox1.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = Otbor.MainOtbor();
                textBox2.Text = Papa.infoSmall;
                textBox3.Text = Papa.infoBig;
            }
            catch { textBox2.Text = "Error"; }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox2.Text = "wait...";
            textBox1.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                x = Vsyo.MainVsyo();
                textBox1.Text = "";
                textBox2.Text = Papa.infoSmall;
                textBox3.Text = Papa.infoBig;

            }
            catch { textBox2.Text = "Error"; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Papa.infoSmall = "";
            Papa.infoBig = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            int x = 0;
            try
            {
                //x = Otmena();
                Papa.infoSmall = "";
                Papa.infoBig = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch { textBox2.Text = "Error"; }
        }
    }
}
