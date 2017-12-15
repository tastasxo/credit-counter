using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace credit_counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "") // if the text box (txtb_costpercredit) equals to 0 or null then
            {
                MessageBox.Show("You have not set the cost of a credit"); // display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label_1p.Text); // covert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the 1p is clicked it increases by 1
                label_1p.Text = hold_number.ToString();
                // work out total penny
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the 1p is clicked it increases by 1
                txtbox_totalvpence.Text = hold_number.ToString();
                // work out total pound - string of pence into a double then divides by 100 then formats it back into a string in correct currency
                txtbox_totalvpound.Text = String.Format("{0:n2}", Convert.ToDouble(txtbox_totalvpence.Text) / 100);
                // present number of credits - shows the total number of credit in a whole number
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                txtbox_presentcredit.Text = hold_number.ToString(); // presents the credit in an int
                  
                








            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "") // if the text box (txtb_costpercredit) equals to 0 or null then
            {
                MessageBox.Show("You have not set the cost of a credit"); // display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label_10p.Text); // convert the value of the hold_number into a interger
                hold_number = hold_number + 10; // when the 10p is clicked it increases by 10
                label_10p.Text = hold_number.ToString();
                // work out total penny
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                hold_number = hold_number + 10; // when the 10p is clicked it increases by 10
                txtbox_totalvpence.Text = hold_number.ToString();
                // work out total pound - string of pence into a double then divides by 100 then formats it back into a string in correct currency
                txtbox_totalvpound.Text = String.Format("{0:n2}", Convert.ToDouble(txtbox_totalvpence.Text) / 100);
                // present number of credits - shows the total number of credit in a whole number
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                txtbox_presentcredit.Text = hold_number.ToString(); // presents the credit in an int


            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "")// if the text box (txtb_costpercredit) equals to 0 or null
            {
                MessageBox.Show("You have not set the cost of a credit"); // display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label_2p.Text);// convert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the 2p is clicked then it increases by 1
                label_2p.Text = hold_number.ToString();
                // work out total penny
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                hold_number = hold_number + 2; // when the 2p is clicked it increases by 2
                txtbox_totalvpence.Text = hold_number.ToString();
                // work out total pound - string of pence into a double then divides by 100 then formats it back into a string in correct currency
                txtbox_totalvpound.Text = String.Format("{0:n2}", Convert.ToDouble(txtbox_totalvpence.Text) / 100);
                // present number of credits - shows the total number of credit in a whole number
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                txtbox_presentcredit.Text = hold_number.ToString(); // presents the credit in an int



            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "") // if the text box (txtb_costpercredit) equals to 0 or null
            {
                MessageBox.Show("You have not set the cost of a credit"); // display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label_20p.Text);// convert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the 20p is clicked it increases by 1
                label_20p.Text = hold_number.ToString();
                // work out total penny
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                hold_number = hold_number + 20; // when the 20p is clicked it increases by 20
                txtbox_totalvpence.Text = hold_number.ToString();
                // work out total pound - string of pence into a double then divides by 100 then formats it back into a string in correct currency
                txtbox_totalvpound.Text = String.Format("{0:n2}", Convert.ToDouble(txtbox_totalvpence.Text) / 100);
                // present number of credits - shows the total number of credit in a whole number
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                txtbox_presentcredit.Text = hold_number.ToString(); // presents the credit in an int

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "") // if the text box (txtb_costpercredit) equals to 0 or null
            {
                MessageBox.Show("You have not set the cost of a credit");// display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label_50p.Text);// convert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the 50p is clicked then it increase by 1
                label_50p.Text = hold_number.ToString();
                // work out total penny
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                hold_number = hold_number + 50; // when the 50p is clicked it increases by 50
                txtbox_totalvpence.Text = hold_number.ToString();
                // work out total pound - string of pence into a double then divides by 100 then formats it back into a string in correct currency
                txtbox_totalvpound.Text = String.Format("{0:n2}", Convert.ToDouble(txtbox_totalvpence.Text) / 100);
                // present number of credits - shows the total number of credit in a whole number
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                txtbox_presentcredit.Text = hold_number.ToString(); // presents the credit in an int

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "") // if the text box (txtb_costpercredit) equals to 0 or null
            {
                MessageBox.Show("You have not set the cost of a credit");// display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label_5p.Text);// convert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the 5p is clicked then it increases by 1
                label_5p.Text = hold_number.ToString();
                // work out total penny
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                hold_number = hold_number + 5; // when the 5p is clicked it increases by 5
                txtbox_totalvpence.Text = hold_number.ToString();
                // work out total pound - string of pence into a double then divides by 100 then formats it back into a string in correct currency
                txtbox_totalvpound.Text = String.Format("{0:n2}", Convert.ToDouble(txtbox_totalvpence.Text) / 100);
                // present number of credits - shows the total number of credit in a whole number
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                txtbox_presentcredit.Text = hold_number.ToString(); // presents the credit in an int

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "") // if the text box (txtb_costpercredit) equals to 0 or null
            {
                MessageBox.Show("You have not set the cost of a credit");// display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label_pound.Text);// convert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the £1 is clicked then it increases by 1
                label_pound.Text = hold_number.ToString();
                // work out total penny
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                hold_number = hold_number + 100; // when the £1 is clicked it increases by 100p
                txtbox_totalvpence.Text = hold_number.ToString();
                // work out total pound - string of pence into a double then divides by 100 then formats it back into a string in correct currency
                txtbox_totalvpound.Text = String.Format("{0:n2}", Convert.ToDouble(txtbox_totalvpence.Text) / 100);
                // present number of credits - shows the total number of credit in a whole number
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                txtbox_presentcredit.Text = hold_number.ToString(); // presents the credit in an int

            }
        }



        private void picbox_2pound_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "") // if the text box (txtb_costpercredit) equals to 0 or null
            {
                MessageBox.Show("You have not set the cost of a credit");// display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label_2pound.Text);// convert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the £2 is clicked then it increases by 1
                label_2pound.Text = hold_number.ToString();
                // work out total penny
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                hold_number = hold_number + 200; // when the £2 is clicked it increases by 200p
                txtbox_totalvpence.Text = hold_number.ToString();
                // work out total pound - string of pence into a double then divides by 100 then formats it back into a string in correct currency
                txtbox_totalvpound.Text = String.Format("{0:n2}", Convert.ToDouble(txtbox_totalvpence.Text) / 100);
                // present number of credits - shows the total number of credit in a whole number
                hold_number = Convert.ToInt32(txtbox_totalvpence.Text); // covert the value of the hold_number into a interger
                txtbox_presentcredit.Text = hold_number.ToString(); // presents the credit in an int

            }

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            // resets value to 0
            txtbox_presentcredit.Text = "0"; 
            txtbox_totalvpence.Text = "0";
            txtbox_totalvpound.Text = "0";
            txtb_costpercredit.Text = "0";
            label_1p.Text = "0";
            label_2p.Text = "0";
            label_5p.Text = "0";
            label_10p.Text = "0";
            label_20p.Text = "0";
            label_50p.Text = "0";
            label_pound.Text = "0";
            label_2pound.Text = "0";
        



        }




    }
}

