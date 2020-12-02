//Grading ID: K1791
//Program 1
//22 September 2020
//CIS 199-02
//A program that will give an estimate on the cost of materials for a hardwood sales and installation company.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) //IGNORE THIS, GO DOWN
        {

        }

        private void Form1_Load(object sender, EventArgs e) //IGNORE THIS, GO DOWN
        {

        }

        private void button1_Click(object sender, EventArgs e) //IGNORE THIS, GO DOWN
        {

        }

        //When this button is pressed, the calculations below will be carried out.
        private void calculationButton_Click(object sender, EventArgs e)
        {

            //A list of constant doubles, and ints used in this program, ALSO GRABBING user input

            const double underlaymentCost = 4.25; //Underlayment cost for each square yard
            const double wasteExcess = .10; //10% excess fee
            int firstRoomCost = 50; //The fee for the first room is $50
            const double squareYardsConversion = 9; //The feet must be converted into yards
            const double laborSquareCost = 3.25; //For each square yard, this will be multiplied
           
            



        
            string input1;
            input1 = maxWidthTextbox.Text;
            double maxWidth = double.Parse(input1); //Takes the width and asigns it as a double according to user input.

            string input2;
            input2 = maxLengthTextbox.Text;
            double maxLength = double.Parse(input2); //Takes the length and asigns it as a double according to user input.

            string input3;
            input3 = hardwoodPriceTextbox.Text;
            double hardwoodCost = double.Parse(input3); //Takes the hardwood cost  and asigns it as a double according to user input.

            string input4;
            input4 = underlaymentTextbox.Text;
            int underlayment = int.Parse(input4); //Takes the underlayment yes or no, and asigns it as a double according to user input.






            //Convert Feet to Yard



            double squareYardsCalculation = (maxWidth * maxLength) / squareYardsConversion; //Multiplying maxwidth and yards, and dividing by the constant double square yards conversion

            squareYardsCostOutput.Text = squareYardsCalculation.ToString("N1"); //Sending our calculation to the output box




            //Hardwood Costs

            double hardwoodCostCalculation1 = (hardwoodCost * squareYardsCalculation) * (wasteExcess); //Calculates the excess value
            double hardwoodCostCalculation2 = (hardwoodCost * squareYardsCalculation); //Calculates the normal hardwood value
            double trueHardwoodCostCalculation = (hardwoodCostCalculation1 + hardwoodCostCalculation2); //Combines the prior two into one final cost
            hardwoodCostOutput.Text = trueHardwoodCostCalculation.ToString("C"); //Displays the value we calculated earlier

            //Underlayment Costs
            int underlay;
            underlay = int.Parse(underlaymentTextbox.Text);

            double underlayCost = squareYardsCalculation * underlay * underlaymentCost;

            underlayCostOutput.Text = underlayCost.ToString("C");

            

            //First Room Cost

            int firstRoom;
            firstRoom = int.Parse(firstRoomTextbox.Text);

            
            firstRoom = int.Parse(firstRoomTextbox.Text);

            //Labor Costs

            double laborCost;
            laborCost = firstRoom * firstRoomCost + (squareYardsCalculation * laborSquareCost);

            laborCostOutput.Text = laborCost.ToString("C");
            



            //Total Cost 

            
            double finalCalculation = trueHardwoodCostCalculation + laborCost + underlayCost; //Total Cost calculation 
            

            totalCostOutput.Text = finalCalculation.ToString("C"); 

            







        }
    }
}
