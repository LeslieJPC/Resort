using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpringBreak
{
    public partial class Form1 : Form
    {// Coded by ########
     // Definition of needed variables
        int NumGuests = 0, NumNights = 0, NumRooms = 0, RoomIndex = 0;
        double RoomCost = 0, TotalCost = 0;
        const double TaxRate = 0.0825, DoubleCost = 250, 
            MiniSuiteCost = 350, SuiteCost = 450;
        string st1 = "";
        string st2 = "";
        string greet1 = "Thank You. Our staff" +
            " will ensure that you and your ";
        string greet2 = " guests have a memorable ";
        string greet3 = " day stay at our resort.";
        string greet4 = " Thank You,";
        string greet5 = " Alex Johansen ";
        string greet6 = "General Manager ";
        string bigone = "";
        public Form1()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {//This is the codebehind button1 PROCESS
            try
            {
                GetInput();
                ProcessData();
                ProduceOutput();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void GetInput()
        {
            try
            {
                NumGuests = int.Parse(textBox1.Text);
                NumNights = int.Parse(textBox3.Text);
                NumRooms = int.Parse(textBox2.Text);
                GetRoomCost();

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void GetRoomCost()
        {
            try
            {
                RoomIndex = comboBox1.SelectedIndex;
                if (RoomIndex == 2)
                    RoomCost = SuiteCost;
                else if (RoomIndex == 1)
                    RoomCost = MiniSuiteCost;
                else if (RoomIndex == 0)
                    RoomCost = DoubleCost;
                else
                {
                    RoomCost = DoubleCost;
                    MessageBox.Show("No room type selected. A double has been assigned");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void ProcessData()
        {
            try
            {
                TotalCost = NumNights * NumRooms * 
                    RoomCost * (1 + TaxRate);
                            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ProduceOutput()
        {
            try
            {
                //Put Thank You Phrase In Proper Label
                label5.Text = TotalCost.ToString("C");
                st1 = NumGuests.ToString("N0");
                st2 = NumNights.ToString("N0");
                bigone = greet1 + st1 + greet2 + st2 
                    + greet3 + greet4 + greet5 + greet6;
                label6.Text = bigone;
                label6.Visible = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//This is the codebehind button2 CLEAR ALL
            try
            {
                ClearInput();
                ClearProcess();
                ClearOutput();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ClearInput()
        {
            try
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label5.Text = "";
                comboBox1.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ClearProcess()
        {
            try
            {
                NumGuests = 0; NumNights = 0; RoomIndex = 0;
                RoomCost = 0; TotalCost = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ClearOutput()
        {
            try
            {
                //Put blank in textbox with greeting
                //Put blank in label with total cost
                label6.Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {//This is the codebehind button 3 EXIT
            try
            {
                MessageBox.Show(" About to terminate the application.");
                Application.Exit();
                MessageBox.Show(" The application just terminated.");
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
