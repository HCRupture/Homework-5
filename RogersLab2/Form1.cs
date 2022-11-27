using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogersLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*  Noah Rogers
         *  October 6 2022
         *  Lab 2
         *  This lab has us assembling a basic project divided into 2 sections. The first section is a feature that allows the user to multiply 2 integers of their choice by entering them into text boxes and pressing the "calculate" button below. Next to that, a clear button where they can quickly empty the boxes and perform as many calculations as they wish. The second section is a short dicussion on a topic of the creators choosiing. The data shown can be brought up and hidden with the click of a button as well as a picture related to the topic. if the picture is clicked a messagebox appears where additional information is shown. Finally, there is an "exit" button to close the program.
         */

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the application

            this.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //Show Picture and hide data label

            pbxOllie.Show();
            lblData.Hide(); 

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //Hide Picture and data label

            lblData.Hide();
            pbxOllie.Hide();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clear textboxes and answer label

            txtbxNumber.Text = null;
            txtbxMultiplier.Text = null;
            lblAnswer.Text = null;

            //place cursor on top textbox

            txtbxNumber.Focus();
        }

        private void btnData_Click(object sender, EventArgs e)
        {

            //Hide the picture and Show Data Label 

            pbxOllie.Hide();
            lblData.Show();
            lblData.Text = "    my topic is " + lblTopic.Text + ". Ollie is our families current pet dog who we recieved last January. He was born in November so he is quickly approaching 1 year old. He is a Golden retriever, a great breed of dog to own, but it comes with a few caveats. \n \n   The first thing you must do when you get a golden retriever is to say goodbye to all of your clothes, they will now be covered in yellow hairs at all times. You will also find that you will never be able to eat alone ever again. Lastly, all Golden retrievers apparently are known to be sloppy drinkers. None of us knew this beforehand. Ollie's water dish has been moved away from the kitchen to a remote corner of the home.";
        }

        private void pbxOllie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ollie recieving his first rawhide chew the day after we first brought him home", "Noah Rogers");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //first declare 2 local variables as integers
            int number, multiplier;

            //then declarea answer as a double
            double answer;

            //read from the textboxes and convert into integers

            number = Convert.ToInt32(txtbxNumber.Text);
            multiplier = Convert.ToInt32(txtbxMultiplier.Text);

            //Perform the operation

            answer = number * multiplier;

            //display the answer - convert

            lblAnswer.Text = answer.ToString();

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }
    }
}
